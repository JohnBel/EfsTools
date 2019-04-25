using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using EfsTools.Qualcomm.QcdmCommands;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Qualcomm.QcdmCommands.Requests;
using EfsTools.Qualcomm.QcdmCommands.Responses;
using EfsTools.Qualcomm.QcdmManagers;
using EfsTools.Resourses;
using EfsTools.Utils;
using Microsoft.Win32;

namespace EfsTools.Qualcomm
{
    internal class QcdmManagerException : Exception
    {
        public QcdmManagerException(string message)
            : base(message)
        {
        }
    }

    internal class QcdmManager : IDisposable
    {
        private const int NvItemSize = 128;
        private const int NvPeekMaxSize = 32;
        private const int MaxPacketDataSize = 2048;
        private const int MaxPacketSize = MaxPacketDataSize * 2;
        private const int RxTimeout = 15 * 1000;
        private const int SpcLength = 6;
        private const int PasswordLength = 16;

        private readonly HdlcSerial _port;
        private bool _doEventReport;

        public QcdmManager(string port, int baudrate, int timeout)
        {
            _doEventReport = false;
            var realPort = GetSerialPort(port);
            _port = new HdlcSerial(realPort, baudrate, timeout);
            Gsm = new QcdmGsmManager(this);
            CallManager = new QcdmCallManager(this);
            Efs = new QcdmEfsManager(this);
            Nv = new QcdmNvManager(this);
        }

        public bool IsOpen => _port.IsOpen;
        public string PortName => _port.PortName;

        public ushort DiagVersion
        {
            get
            {
                if (IsOpen)
                {
                    var request = new DiagVersionCommandRequest();
                    var response = (DiagVersionCommandResponse) ExecuteQcdmCommandRequest(request);
                    return response.Version;
                }

                return 0;
            }
        }

        public QcdmVersion Version
        {
            get
            {
                if (IsOpen)
                {
                    var request = new VersionCommandRequest();
                    var response = (VersionCommandResponse) ExecuteQcdmCommandRequest(request);
                    return response.Version;
                }

                return null;
            }
        }

        public Guid Guid
        {
            get
            {
                if (IsOpen)
                {
                    var request = new GuidCommandRequest();
                    var response = (GuidCommandResponse) ExecuteQcdmCommandRequest(request);
                    return response.Guid;
                }

                return Guid.Empty;
            }
        }

        public DateTime SystemTime
        {
            get
            {
                if (IsOpen)
                {
                    var request = new TimeCommandRequest();
                    var response = (TimeCommandResponse) ExecuteQcdmCommandRequest(request);
                    return response.Time;
                }

                return DateTime.MinValue;
            }
        }

        public ExtentedBuildId BuildId
        {
            get
            {
                if (IsOpen)
                {
                    var request = new ExtentedBuildIdCommandRequest();
                    var response = (ExtentedBuildIdCommandResponse) ExecuteQcdmCommandRequest(request);
                    return response.BuildId;
                }

                return null;
            }
        }

        public string Imei
        {
            get
            {
                var bytes = Nv.Read(550);
                var imei = new StringBuilder(15);
                for (var i = 1; i <= 8; ++i)
                {
                    var b = bytes[i];
                    var b1 = (b & 0xF0) >> 4;
                    var b2 = b & 0x0F;
                    if (i == 1)
                    {
                        imei.AppendFormat("{0:X}", b1);
                    }
                    else
                    {
                        var v = b1 | (b2 << 4);
                        imei.AppendFormat("{0:X2}", v);
                    }
                }

                return imei.ToString();
            }
        }
        public QcdmGsmManager Gsm { get; }

        public QcdmCallManager CallManager { get; }

        public QcdmEfsManager Efs { get; }

        public QcdmNvManager Nv { get; }

        public void Dispose()
        {
            if (_doEventReport)
            {
                DisableEventReports();
            }
            DisableLogs();
            DisableMessages();
            _port?.Dispose();
        }

        public void Open()
        {
            _port.Open();
        }

        public void Close()
        {
            _port.Close();
        }

        public void EventReport(bool enable)
        {
            if (IsOpen)
            {
                var request = new EventReportCommandRequest(enable);
                var response = (EventReportCommandResponse) ExecuteQcdmCommandRequest(request);
                if (response.IsError) 
                    throw new QcdmEfsException(Strings.QcdmErrorOnSetEventMask);
                _doEventReport = enable;
            }
        }

        public bool DisableEventReports()
        {
            try
            {
                EventReport(false);
                SetEventMask(new EventId[0]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DisableMessages()
        {
            try
            {
                SetMessageMask(0, 256, new MessageId[0]);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DisableLogs()
        {
            try
            {
                SetLogMask(new LogId[0]);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public EventId[] SetEventMask(EventId[] enabledEvents)
        {
            if (IsOpen)
            {
                var request = new EventMaskSetCommandRequest(enabledEvents);
                var response = (EventMaskSetCommandResponse) ExecuteQcdmCommandRequest(request);
                if (response.IsError) 
                    throw new QcdmEfsException(Strings.QcdmErrorOnSetEventMask);
                return response.EnabledEvents;
            }
            return null;
        }

        public MessageId[] SetMessageMask(int start, int end, MessageId[] enabledMessageMask)
        {
            if (IsOpen)
            {
                var request = new ExtMessageConfigCommandRequest(4, start, end, enabledMessageMask);
                var response = (ExtMessageConfigCommandResponse) ExecuteQcdmCommandRequest(request);
                if (response.IsError) 
                    throw new QcdmEfsException(Strings.QcdmErrorOnSetEventMask);
                return response.EnabledMessages;
            }
            return null;
        }

        public string QueryLog()
        {
            if (IsOpen)
            {
                var request = new LogCommandRequest();
                var response = (LogCommandResponse) ExecuteQcdmCommandRequest(request);
                return response.Message;
            }

            return null;
        }

        public LogId[] SetLogMask(LogId[] enabledLogIds)
        {
            if (IsOpen)
            {
                var request = new LogConfigCommandRequest(LogConfigOperation.SetMask,  1, enabledLogIds);
                var response = (LogConfigCommandResponse) ExecuteQcdmCommandRequest(request);
                if (response.IsError) 
                    throw new QcdmEfsException(Strings.QcdmInvalidLogMask);
                return response.EnabledLogs;
            }
            return new LogId[0];
        }

        public void SendSpc(string spc)
        {
            if (IsOpen)
            {
                var request = new SpcCommandRequest(spc);
                var response = (SpcCommandResponse) ExecuteQcdmCommandRequest(request);
                if (response.IsError) 
                    throw new QcdmEfsException(Strings.QcdmInvalidSpc);
            }
        }

        public void SendPassword(string password)
        {
            if (IsOpen)
            {
                var request = new PasswordCommandRequest(password);
                var response = (PasswordCommandResponse) ExecuteQcdmCommandRequest(request);
                if (response.IsError) 
                    throw new QcdmEfsException(Strings.QcdmInvalidPassword);
            }
        }

        public void ProcessLogs(Logger logger, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var response = ReadLogResponse();
                if (response != null)
                { 
                    var command = response.Command;
                    switch (command)
                    {
                        case QcdmCommand.Log:
                            LogResponse(logger, (LogCommandResponse)response);
                            break;
                        case QcdmCommand.Msg:
                            LogResponse(logger, (MsgCommandResponse)response);
                            break;
                        case QcdmCommand.ExtMsg:
                            LogResponse(logger, (ExtMsgCommandResponse)response);
                            break;
                        case QcdmCommand.EventReport:
                            LogResponse(logger, (EventReportCommandResponse)response);
                            break;
                    }
                }
            }
        }

        private IQcdmCommandResponse ReadLogResponse()
        {
            try
            {
                var responseData = _port.Read();
                var response = CreateResponse(responseData);
                return response;
            }
            catch 
            {
                return null;
            }
        }

        private static void LogResponse(Logger logger, LogCommandResponse response)
        {
            logger.LogInfo("[LOG]  {0} {1} ({2})\t{3}", response.Time, response.LogId, response.Source, response.Message);
        }

        private static void LogResponse(Logger logger, MsgCommandResponse response)
        {
            logger.LogInfo("[MSG]  [{0}] {1}", response.MessageId, response.Log);
        }
        private static void LogResponse(Logger logger, ExtMsgCommandResponse response)
        {
            logger.LogInfo("[MSG]  {0} {1}\t{2}  ({3}) Drop count = {4}", response.Time, response.MessageId, 
                response.Message, response.Source, response.DropCount);
        }

        private static void LogResponse(Logger logger, EventReportCommandResponse response)
        {
            foreach (var ev in response.Events)
            {
                logger.LogInfo("[EVT]  {0} {1}", ev.Time, ev.EventId);
            }
        }

        public IQcdmCommandResponse ExecuteQcdmCommandRequest(IQcdmCommandRequest request)
        {
            if (!IsOpen) 
                throw new QcdmManagerException(Strings.QcdmSerialPortIsNotOpen);

            var data = request.GetData();
            _port.Write(data);

            bool doRead = true;
            IQcdmCommandResponse response = null;
            int counter = 0;
            while (doRead)
            {
                var responseData = _port.Read();
                response = CreateResponse(responseData);
                doRead = (response.Command != request.Command);
                ++counter;
                if (counter > 15)
                {
                    throw new QcdmManagerException(Strings.QcdmManyLogLines);
                }
            }
            return response;
        }

        private IQcdmCommandResponse CreateResponse(byte[] responseData)
        {
            if (responseData == null || responseData.Length == 0)
                throw new QcdmManagerException(Strings.QcdmInvalidResponse);

            var command = (QcdmCommand) responseData[0];
            CheckError(command);
            return QcdmCommandResponseFactory.CommandResponse(command, responseData);
        }

        private void CheckError(QcdmCommand command)
        {
            string message = null;
            switch (command)
            {
                case QcdmCommand.BadCmd:
                    message = Strings.QcdmCommandBadCmd;
                    break;
                case QcdmCommand.BadParm:
                    message = Strings.QcdmCommandBadParm;
                    break;
                case QcdmCommand.BadLen:
                    message = Strings.QcdmCommandBadLen;
                    break;
                case QcdmCommand.BadMode:
                    message = Strings.QcdmCommandBadMode;
                    break;
                case QcdmCommand.BadSpcMode:
                    message = Strings.QcdmCommandBadSpcMode;
                    break;
            }

            if (message != null) throw new QcdmManagerException(message);
        }

        private static string GetSerialPort(string port)
        {
            try
            {
                if (string.IsNullOrEmpty(port) || port.ToLowerInvariant() == "auto")
                {
                    return DetectSerialPort();
                }
                return port;
            }
            catch
            {
                return port;
            }
        }

        private static string DetectSerialPort()
        {
            var ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                if (QualcommSerialPortUtils.IsQualcommPort(port))
                {
                    return port;
                }
            }
            return ports.FirstOrDefault();
        }
    }
}