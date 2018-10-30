using System;
using System.IO;
using EfsTools.Qualcomm;

namespace EfsTools.Utils
{
    internal sealed class QcdmManagerNvWriteStreamAdapter : Stream, IDisposable
    {
        private readonly ushort _id;

        private readonly QcdmManager _manager;
        private readonly MemoryStream _stream;
        private bool _closed;

        public QcdmManagerNvWriteStreamAdapter(QcdmManager manager, ushort id)
        {
            _manager = manager;
            _stream = new MemoryStream();
            _id = id;
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
            try
            {
                WriteNv();
                _stream?.Dispose();
                base.Dispose();
            }
            catch
            {
            }
        }

        public override void Close()
        {
            WriteNv();
            _stream.Close();
        }

        public override void Flush()
        {
            _stream.Flush();
            WriteNv();
        }

        private void WriteNv()
        {
            if (!_closed)
            {
                var buf = _stream.GetBuffer();
                var data = new byte[_stream.Position];
                Array.Copy(buf, 0, data, 0, _stream.Position);
                _manager.Nv.Write(_id, data);
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