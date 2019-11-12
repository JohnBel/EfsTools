using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            DiagServ = new QcdmDiagServManager(this);
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

        public QcdmDiagServManager DiagServ { get; }

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
                var messageIdRanges = GetMessageIdRanges();
                var messages = new MessageId[0];
                foreach (var messageIdRange in messageIdRanges)
                {
                    SetMessageMask((int)messageIdRange.Item1, (int)messageIdRange.Item2, messages);
                }
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
                var logItemsRange = GetLogIdRanges();
                var scopeId = 1;
                var masks = new LogId[0];
                foreach (var logRange in logItemsRange)
                {
                    var logScope = scopeId * 0x1000;
                    var affectedMasks = SetLogMask(scopeId, logRange, masks);
                    ++scopeId;
                }
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

        private MessageId[] SetMessageMask(int start, int end, MessageId[] enabledMessageMask)
        {
            if (IsOpen)
            {
                var request = new ExtMessageConfigCommandRequest(ExtMessageConfigOperation.SetMask, start, end, enabledMessageMask);
                var response = (ExtMessageConfigCommandResponse) ExecuteQcdmCommandRequest(request);
                if (response.IsError) 
                    throw new QcdmEfsException(Strings.QcdmErrorOnSetEventMask);
                return response.Messages;
            }
            return null;
        }

        public MessageId[] SetMessageMask(MessageId[] enabledMessageMask)
        {
            var result = new List<MessageId>(enabledMessageMask.Length);
            var messageIdRanges = GetMessageIdRanges();
            foreach (var messageIdRange in messageIdRanges)
            {
                var messages = enabledMessageMask.Where((it) => (it >= messageIdRange.Item1 && it <= messageIdRange.Item2)).ToArray();
                var affectedMessages = SetMessageMask((int)messageIdRange.Item1, (int)messageIdRange.Item2, messages);
                if (affectedMessages != null)
                {
                    result.AddRange(affectedMessages);
                }
            }
            return result.ToArray();
        }


        public Tuple<MessageId, MessageId>[] GetMessageIdRanges()
        {
            if (IsOpen)
            {
                var request = new ExtMessageConfigCommandRequest(ExtMessageConfigOperation.RetrieveIdRanges, 0, 0, null);
                var response = (ExtMessageConfigCommandResponse)ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                {
                    throw new QcdmEfsException(Strings.QcdmErrorOnSetEventMask);
                }

                var messages = response.Messages;
                if (messages != null)
                {
                    var result = new Tuple<MessageId, MessageId>[messages.Length / 2];
                    var pos = 0;
                    for (int i = 0; i < result.Length; ++i)
                    {
                        var pair = new Tuple<MessageId, MessageId>(messages[pos], messages[pos + 1]);
                        pos += 2;
                        result[i] = pair;
                    }
                    return result;
                }
            }
            return null;
        }

        public MessageIdState[] GetMessageIdStates(MessageId start, MessageId end)
        {
            if (IsOpen)
            {
                var request = new ExtMessageConfigCommandRequest(ExtMessageConfigOperation.RetrieveValidMask, (int)start, (int)end, null);
                var response = (ExtMessageConfigCommandResponse)ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                {
                    throw new QcdmEfsException(Strings.QcdmErrorOnSetEventMask);
                }

                var messages = response.MessageStates;
                return messages;
            }
            return null;
        }

        public Tuple<EventId, EventId>[] GetEventIdRanges()
        {
            if (IsOpen)
            {
                var request = new EventMaskGetCommandRequest();
                var response = (EventMaskGetCommandResponse)ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                {
                    throw new QcdmEfsException(Strings.QcdmErrorOnSetEventMask);
                }

                var events = response.Events;
                if (events != null)
                {
                    var result = new Tuple<EventId, EventId>[events.Length / 2];
                    var pos = 0;
                    for (int i = 0; i < result.Length; ++i)
                    {
                        var pair = new Tuple<EventId, EventId>(events[pos], events[pos + 1]);
                        pos += 2;
                        result[i] = pair;
                    }
                    return result;
                }
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

        public LogId[] SetLogMask(LogId[] enabledLogMask)
        {
            var result = new List<LogId>(enabledLogMask.Length);
            var logItemsRange = GetLogIdRanges();
            var scopeId = 1;
            foreach (var logRange in logItemsRange)
            {
                var logScope = scopeId * 0x1000;
                var masks = enabledLogMask.Where((it) => ((it - logScope) >= logRange.Item1 && (it - logScope) <= logRange.Item2)).ToArray();
                var affectedMasks = SetLogMask(scopeId, logRange, masks);
                result.AddRange(affectedMasks);
                ++scopeId;
            }
            return result.ToArray();
        }

        private LogId[] SetLogMask(int scopeId, Tuple<LogId, LogId> range, LogId[] enabledLogIds)
        {
            if (IsOpen)
            {
                var request = new LogConfigCommandRequest(LogConfigOperation.SetMask,  scopeId, range, enabledLogIds);
                var response = (LogConfigCommandResponse) ExecuteQcdmCommandRequest(request);
                if (response.IsError) 
                    throw new QcdmEfsException(Strings.QcdmInvalidLogMask);
                return response.LogIds;
            }
            return new LogId[0];
        }

        public Tuple<LogId, LogId>[] GetLogIdRanges()
        {
            if (IsOpen)
            {
                var request = new LogConfigCommandRequest(LogConfigOperation.RetrieveIdRanges, 0, null, null);
                var response = (LogConfigCommandResponse)ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                    throw new QcdmEfsException(Strings.QcdmInvalidLogMask);
                var logIds = response.LogIds;
                var count = logIds.Length / 2;
                var pos = 0;
                var result = new Tuple<LogId, LogId>[count];
                for (var i = 0; i < count; ++i)
                {
                    var pair = new Tuple<LogId, LogId>(logIds[pos], logIds[pos + 1] + 0x1000);
                    pos += 2;
                    result[i] = pair;
                }
                return result;
            }
            return new Tuple<LogId, LogId>[0];
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
                            LogDelimeter(logger);
                            break;
                        case QcdmCommand.Msg:
                            LogResponse(logger, (MsgCommandResponse)response);
                            LogDelimeter(logger);
                            break;
                        case QcdmCommand.ExtMsg:
                            LogResponse(logger, (ExtMsgCommandResponse)response);
                            LogDelimeter(logger);
                            break;
                        case QcdmCommand.EventReport:
                            LogResponse(logger, (EventReportCommandResponse)response);
                            LogDelimeter(logger);
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
                if (Debugger.IsAttached)
                {
                    var sb = new StringBuilder();
                    sb.Append("< ");
                    sb.Append(QcdmCommandUtils.ToString(responseData));
                    LogDebug(sb.ToString());
                }
                var response = CreateResponse(responseData);
                return response;
            }
            catch 
            {
                return null;
            }
        }

        private static void LogDelimeter(Logger logger)
        {
            logger.LogInfo("----------------------------------------------------------------------------------------");
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
        private void LogDebug(string message)
        {
            Debug.WriteLine(message);
        }

        private void LogCommandRequestDebug(QcdmCommand command, byte[] data)
        {
            var sb = new StringBuilder();
            sb.Append("> ");
            sb.Append(QcdmCommandUtils.ToString(command, data));
            LogDebug(sb.ToString());
        }

        private void LogCommandResponseDebug(QcdmCommand command, byte[] data)
        {
            var sb = new StringBuilder();
            sb.Append("< ");
            sb.Append(QcdmCommandUtils.ToString(command, data));
            LogDebug(sb.ToString());
        }
        public IQcdmCommandResponse ExecuteQcdmCommandRequest(IQcdmCommandRequest request)
        {
            if (!IsOpen) 
                throw new QcdmManagerException(Strings.QcdmSerialPortIsNotOpen);
            var logCommands = Debugger.IsAttached;
            var data = request.GetData();
            if (logCommands)
            {
                LogCommandRequestDebug(request.Command, data);
            }
            _port.Write(data);

            bool doRead = true;
            IQcdmCommandResponse response = null;
            int counter = 0;
            while (doRead)
            {
                var responseData = _port.Read();
                if (logCommands)
                {
                    LogCommandResponseDebug(request.Command, responseData);
                }
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