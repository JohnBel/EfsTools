using System;
using System.IO;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmManagers;

namespace EfsTools.Utils
{
    internal sealed class QcdmManagerStreamAdapter : Stream, IDisposable
    {
        private readonly QcdmManager _manager;
        private readonly QcdmEfsFileStream _stream;

        public QcdmManagerStreamAdapter(QcdmManager manager, QcdmEfsFileStream stream)
        {
            _manager = manager;
            _stream = stream;
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
            _manager?.Dispose();
            base.Dispose();
        }

        public override void Close()
        {
            _stream.Close();
            if (_manager != null)
            {
                _manager.Close();
            }
        }

        public override void Flush()
        {
            _stream.Flush();
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