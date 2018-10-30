using System;
using System.IO;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Requests.Efs;

namespace EfsTools.Utils
{
    internal sealed class QcdmManagerItemWriteStreamAdapter : Stream, IDisposable
    {
        private readonly QcdmManager _manager;
        private readonly string _path;
        private readonly int _permission;
        private readonly MemoryStream _stream;
        private bool _closed;

        public QcdmManagerItemWriteStreamAdapter(QcdmManager manager, string path, int permission)
        {
            _manager = manager;
            _stream = new MemoryStream();
            _path = path;
            _permission = permission;
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
                WriteItemFile();
                _stream?.Dispose();
                base.Dispose();
            }
            catch
            {
            }
        }

        public override void Close()
        {
            WriteItemFile();
            _stream.Close();
        }

        public override void Flush()
        {
            _stream.Flush();
            WriteItemFile();
        }

        private void WriteItemFile()
        {
            if (!_closed)
            {
                var flags = EfsFileFlag.Writeonly | EfsFileFlag.Truncate | EfsFileFlag.Create | EfsFileFlag.ItemFile;
                var buf = _stream.GetBuffer();
                var data = new byte[_stream.Position];
                Array.Copy(buf, 0, data, 0, _stream.Position);
                _manager.Efs.PutItemFile(_path, flags, _permission, data);
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