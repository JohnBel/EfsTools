using System;
using EfsTools.Utils;
using RJCP.IO.Ports;

namespace EfsTools.Qualcomm
{
    internal class HdlcSerial : IDisposable
    {
        private readonly SerialPortStream _port;

        private readonly byte[] _readBuffer = new byte[1048576];

        private readonly bool _sendControlChar;

        public HdlcSerial(string port, int baudrate, int timeout, bool sendControlChar)
        {
            _port = new SerialPortStream(port, baudrate)
            {
                ReadTimeout = timeout,
                ReadBufferSize = _readBuffer.Length
            };
            _sendControlChar = sendControlChar;
        }

        public bool IsOpen => _port.IsOpen;
        public string PortName => _port.PortName;

        public bool SendControlChar => _sendControlChar;

        public void Dispose()
        {
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

        private void WriteRaw(byte[] data)
        {
            _port.Write(data, 0, data.Length);
        }

        public void Write(byte[] data)
        {
            var encoded = HdlcEncoder.Encode(data, _sendControlChar);
            WriteRaw(encoded);
        }

        private int ReadRaw(byte[] buffer)
        {
            return _port.Read(buffer, 0, buffer.Length);
        }

        public byte[] Read()
        {
            var read = ReadRaw(_readBuffer);
            var decoded = HdlcEncoder.Decode(_readBuffer, read);
            return decoded;
        }
    }
}