using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Qualcomm.QcdmCommands;
using EfsTools.Qualcomm.QcdmCommands.Requests;
using EfsTools.Qualcomm.QcdmCommands.Responses;
using EfsTools.Qualcomm.QcdmManagers;
using EfsTools.Resourses;

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
        public QcdmManager(string port, int baudrate, int timeout)
        {
            _port = new HdlcSerial(port, baudrate, timeout);
            _gsm = new QcdmGsmManager(this);
            _callManager = new QcdmCallManager(this);
            _efs = new QcdmEfsManager(this);
            _nv = new QcdmNvManager(this);
        }

        private readonly HdlcSerial _port;

        public void Open()
        {
            _port.Open();
        }

        public void Close()
        {
            _port.Close();
        }

        public bool IsOpen => _port.IsOpen;

        public UInt16 DiagVersion
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

        public long SystemTime
        {
            get
            {
                if (IsOpen)
                {
                    var request = new TimeCommandRequest();
                    var response = (TimeCommandResponse) ExecuteQcdmCommandRequest(request);
                    return response.Time;
                }

                return 0;
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

        public string QueryLog()
        {
            if (IsOpen)
            {
                var request = new LogCommandRequest();
                var response = (LogCommandResponse) ExecuteQcdmCommandRequest(request);
                return response.Log;
            }

            return null;
        }

        public void SetLogMask(byte mask)
        {
            if (IsOpen)
            {
                var request = new LogMaskCommandRequest(mask);
                var response = (LogMaskCommandResponse)ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                {
                    throw new QcdmEfsException(Strings.QcdmInvalidLogMask);
                }
            }
        }

        public void SendSpc(string spc)
        {
            if (IsOpen)
            {
                var request = new SpcCommandRequest(spc);
                var response = (SpcCommandResponse)ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                {
                    throw new QcdmEfsException(Strings.QcdmInvalidSpc);
                }
            }
        }

        public void SendPassword(string password)
        {
            if (IsOpen)
            {
                var request = new PasswordCommandRequest(password);
                var response = (PasswordCommandResponse)ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                {
                    throw new QcdmEfsException(Strings.QcdmInvalidPassword);
                }
            }
        }

        public string Imei
        {
            get
            {
                var bytes = _nv.Read(550);
                var imei = new StringBuilder(15);
                for (var i = 1; i <= 8; ++i)
                {
                    var b = bytes[i];
                    var b1 = (b & 0xF0) >> 4;
                    var b2 = (b & 0x0F);
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

        public QcdmGsmManager Gsm => _gsm;
        public QcdmCallManager CallManager => _callManager;
        public QcdmEfsManager Efs => _efs;
        public QcdmNvManager Nv => _nv;

        public IQcdmCommandResponse ExecuteQcdmCommandRequest(IQcdmCommandRequest request)
        {
            if (!IsOpen)
            {
                throw new QcdmManagerException(Strings.QcdmSerialPortIsNotOpen);
            }

            var data = request.GetData();
            _port.Write(data);

            var responseData = _port.Read();
            var response = CreateResponse(responseData);
            return response;
        }

        private IQcdmCommandResponse CreateResponse(byte[] responseData)
        {
            if (responseData == null || responseData.Length == 0)
            {
                throw new QcdmManagerException(Strings.QcdmInvalidResponse);
            }

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

            if (message != null)
            {
                throw new QcdmManagerException(message);
            }
        }

        private readonly QcdmGsmManager _gsm;
        private readonly QcdmCallManager _callManager;
        private readonly QcdmEfsManager _efs;
        private readonly QcdmNvManager _nv;

        private const int NvItemSize = 128;
        private const int NvPeekMaxSize = 32;
        private const int MaxPacketDataSize = 2048;
        private const int MaxPacketSize = (MaxPacketDataSize * 2);
        private const int RxTimeout = (15 * 1000);
        private const int SpcLength = 6;
        private const int PasswordLength = 16;

        public void Dispose()
        {
            _port?.Dispose();
        }
    }
}