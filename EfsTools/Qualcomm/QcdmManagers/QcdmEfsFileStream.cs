using System;
using System.IO;
using System.Threading;
using EfsTools.Qualcomm.QcdmCommands;
using EfsTools.Qualcomm.QcdmCommands.Requests.Efs;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmEfsFileStreamException : Exception
    {
        public QcdmEfsFileStreamException(string message)
            : base(message)
        {
        }
    }

    internal class QcdmEfsFileStream : Stream, IDisposable
    {
        private readonly string _fileName;
        private readonly EfsFileFlag _flags;
        private readonly QcdmManager _manager;
        private readonly int _permission;
        private int _file;
        private long _position;
        private FileStat _stat;

        public QcdmEfsFileStream(QcdmManager manager, string fileName, EfsFileFlag flags, int permission)
        {
            _file = -1;
            _fileName = fileName;
            _flags = flags;
            _permission = permission;
            _manager = manager;
            _position = 0;
        }

        public override bool CanRead => _position < Length;
        public override bool CanSeek => true;
        public override bool CanWrite => _flags != EfsFileFlag.Readonly;
        public override long Length => _stat?.Size ?? 0;

        public override long Position
        {
            get => _position;
            set
            {
                if (value < 0)
                    _position = 0;
                else if (value > Length)
                    _position = Length;
                else
                    _position = value;
            }
        }

        public bool IsOpen => _file != -1;

        public new void Dispose()
        {
            if (IsOpen)
            {
                var request = new EfsCloseFileCommandRequest(_file);
                _manager.ExecuteQcdmCommandRequest(request);
                _file = -1;
            }

            base.Dispose();
        }

        public void Open()
        {
            if (!IsOpen)
            {
                CheckManager();
                _stat = Stat();
                var request = new EfsOpenFileCommandRequest(_fileName, _flags, _permission);
                var response = (EfsOpenFileCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                {
                    var errorMessage = QcdmEfsErrorsUtils.EfsErrorString(response.Error);
                    throw new QcdmEfsFileStreamException(string.Format(Strings.QcdmCantOpenEfsFileFormat, _fileName,
                        errorMessage));
                }

                _file = response.File;
                _position = 0;
            }
        }

        public override void Close()
        {
            if (IsOpen)
            {
                CheckManager();
                var request = new EfsCloseFileCommandRequest(_file);
                var response = (EfsCloseFileCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
                QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
                _file = -1;
            }

            base.Close();
        }

        private FileStat Stat()
        {
            var request = new EfsStatFileCommandRequest(_fileName);
            var response = (EfsStatFileCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
            return response.Stat;
        }

        private FileStat FStat()
        {
            var request = new EfsFStatFileCommandRequest(_file);
            var response = (EfsFStatFileCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
            return response.Stat;
        }

        private void CheckManager()
        {
            if (_manager == null) throw new QcdmEfsFileStreamException("Manager is null");
            if (!_manager.IsOpen) throw new QcdmEfsFileStreamException("Manager is not open");
        }

        public override void Flush()
        {
            if (_manager != null)
            {
                var syncSequence = Interlocked.Increment(ref _syncSequence);
                _manager.Efs.SyncNoWait(_fileName, (ushort)syncSequence);
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            switch (origin)
            {
                case SeekOrigin.Begin:
                    if (offset < 0)
                        _position = 0;
                    else
                        _position = Math.Min(offset, Length);
                    break;
                case SeekOrigin.Current:
                {
                    var newPosition = _position + offset;
                    if (newPosition < 0)
                        _position = 0;
                    else
                        _position = Math.Min(newPosition, Length);
                }
                    break;
                case SeekOrigin.End:
                    if (offset > 0)
                    {
                        _position = Length;
                    }
                    else
                    {
                        var newPosition = _position + offset;
                        if (newPosition < 0)
                            _position = 0;
                        else
                            _position = Math.Min(newPosition, Length);
                    }

                    break;
            }

            return _position;
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            var request = new EfsReadFileCommandRequest(_file, (uint) count, (uint) _position);
            var response = (EfsReadFileCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
            QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
            var data = response.Data;
            var read = data.Length;
            Array.Copy(data, 0, buffer, offset, read);
            _position += read;
            return read;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            var request = new EfsWriteFileCommandRequest(_file, (uint) _position, buffer, offset, count);
            var response = (EfsWriteFileCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
            QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
            var written = response.BytesWritten;
            _position += written;
            if (_stat != null) _stat = FStat();
        }

        private static int _syncSequence = 0;
    }
}