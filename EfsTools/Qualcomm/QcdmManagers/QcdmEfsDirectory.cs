using System;
using System.Collections.Generic;
using EfsTools.Qualcomm.QcdmCommands;
using EfsTools.Qualcomm.QcdmCommands.Requests.Efs;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmEfsDirectoryException : Exception
    {
        public QcdmEfsDirectoryException(string message)
            : base(message)
        {
        }
    }

    internal class QcdmEfsDirectory : IDisposable
    {
        private readonly QcdmManager _manager;
        private readonly string _path;

        private int _directory;

        public QcdmEfsDirectory(QcdmManager manager, string path)
        {
            _directory = -1;
            _path = path;
            _manager = manager;
        }

        public bool IsOpen => _directory != -1;

        public void Dispose()
        {
            if (IsOpen)
            {
                var request = new EfsCloseDirectoryCommandRequest(_directory);
                _manager.ExecuteQcdmCommandRequest(request);
                _directory = -1;
            }
        }

        public void Open()
        {
            if (!IsOpen)
            {
                CheckManager();

                var request = new EfsOpenDirectoryCommandRequest(_path);
                var response = (EfsOpenDirectoryCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
                if (response.IsError)
                {
                    var errorMessage = QcdmEfsErrorsUtils.EfsErrorString(response.Error);
                    throw new QcdmEfsDirectoryException(string.Format(Strings.QcdmCantOpenEfsDirectoryFormat, _path,
                        errorMessage));
                }

                _directory = response.Directory;
            }
        }

        public void Close()
        {
            if (IsOpen)
            {
                CheckManager();
                var request = new EfsCloseDirectoryCommandRequest(_directory);
                var response = (EfsCloseDirectoryCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
                QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
                _directory = -1;
            }
        }

        public IEnumerable<DirectoryEntry> QueryEntries()
        {
            if (IsOpen)
            {
                CheckManager();
                var index = 1;
                while (true)
                {
                    var entry = GetEntry(index++);
                    if (entry == null || string.IsNullOrEmpty(entry.Name)) break;
                    yield return entry;
                }
            }
        }

        private DirectoryEntry GetEntry(int index)
        {
            var request = new EfsReadDirectoryCommandRequest(_directory, index);
            var response = (EfsReadDirectoryCommandResponse) _manager.ExecuteQcdmCommandRequest(request);
            if (response.Error == QcdmEfsErrors.InvalidSequence) return null;
            QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
            return response.DirectoryEntry;
        }

        private void CheckManager()
        {
            if (_manager == null) throw new QcdmEfsDirectoryException("Manager is null");
            if (!_manager.IsOpen) throw new QcdmEfsDirectoryException("Manager is not open");
        }
    }
}