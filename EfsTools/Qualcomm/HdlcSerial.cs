using System;
using System.IO.Ports;
using EfsTools.Utils;

namespace EfsTools.Qualcomm
{
    internal class HdlcSerial : IDisposable
    {
        private readonly SerialPort _port;

        private readonly byte[] _readBuffer = new byte[64 * 1024];

        public HdlcSerial(string port, int baudrate, int timeout)
        {
            _port = new SerialPort(port, baudrate) {ReadTimeout = timeout};
        }

        public bool IsOpen => _port.IsOpen;
        public string PortName => _port.PortName;

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
            var encoded = HdlcEncoder.Encode(data);
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