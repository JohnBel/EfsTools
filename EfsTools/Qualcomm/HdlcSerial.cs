using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfsTools.Utils;

namespace EfsTools.Qualcomm
{
    internal class HdlcSerial : IDisposable
    {
        public HdlcSerial(string port, int baudrate, int timeout)
        {
            _port = new SerialPort(port, baudrate) {ReadTimeout = timeout};
        }

        private readonly SerialPort _port;

        public void Open()
        {
            _port.Open();
        }

        public void Close()
        {
            _port.Close();
        }

        public bool IsOpen => _port.IsOpen;

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

        private readonly byte[] _readBuffer = new byte[6 * 1024];

        public void Dispose()
        {
            _port?.Dispose();
        }
    }
}