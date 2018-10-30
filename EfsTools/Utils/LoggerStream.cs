using System;
using System.IO;
using System.Text;

namespace EfsTools.Utils
{
    internal sealed class LoggerStream : Stream, IDisposable
    {
        private readonly Logger _logger;
        private readonly MemoryStream _stream;
        private bool _closed;

        public LoggerStream(Logger logger)
        {
            _logger = logger;
            _stream = new MemoryStream();
            _closed = false;
        }

        public override bool CanRead => _stream.CanRead;
        public override bool CanSeek => _stream.CanSeek;
        public override bool CanWrite => _stream.CanWrite;
        public override long Length => _stream.Length;

        public override long Position
        {
            get => _stream.Position;
            set => _stream.Position = value;
        }

        public new void Dispose()
        {
            _stream?.Dispose();
            base.Dispose();
        }

        public override void Close()
        {
            WriteLog();
            _stream.Close();
        }

        public override void Flush()
        {
            _stream.Flush();
            WriteLog();
        }

        private void WriteLog()
        {
            if (!_closed)
            {
                var buf = _stream.GetBuffer();
                var data = new byte[_stream.Position];
                Array.Copy(buf, 0, data, 0, _stream.Position);
                var str = Encoding.ASCII.GetString(data);
                _logger.LogInfo(str);
                _closed = true;
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _stream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _stream.SetLength(value);
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return _stream.Read(buffer, offset, count);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _stream.Write(buffer, offset, count);
        }
    }
}