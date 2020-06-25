using System;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands
{
    internal enum QcdmEfsErrors
    {
        None = 0,
        NotPermited = 1, /* Operation not permitted */
        NoEntry = 2, /* No such file or directory */
        IoError = 5, /* I/O error */
        DirectoryExist = 6, /* Directory exists */
        BadFileNumber = 9, /* Bad file number */
        OutOfMemory = 12,
        PermissionDenided = 13, /* Permission denied */
        FileExist = 17, /* File exists */
        NotDirectory = 20, /* Not a directory */
        DirectoryNotEmpty = 39,

        InconsistentState = 0x40000001,
        InvalidSequence = 0x40000002,
        DirNotOpen = 0x40000003,
        DirEntNotFound = 0x40000004,
        InvalidPath = 0x40000005,
        PathTooLong = 0x40000006,
        TooManyOpenDirs = 0x40000007,
        InvalidDirEntry = 0x40000008,
        TooManyOpenFiles = 0x40000009,
        UnknownFileType = 0x4000000A,
        NotNandFlash = 0x4000000B,
        UnavailableInfo = 0x4000000C
    }

    internal class QcdmEfsException : Exception
    {
        public QcdmEfsException(string message)
            : base(message)
        {
        }
    }

    internal static class QcdmEfsErrorsUtils
    {
        public static string EfsErrorString(QcdmEfsErrors error)
        {
            string message = null;
            switch (error)
            {
                case QcdmEfsErrors.None:
                    break;
                case QcdmEfsErrors.InconsistentState:
                    message = Strings.QcdmEfsErrorsInconsistentState;
                    break;
                case QcdmEfsErrors.InvalidSequence:
                    message = Strings.QcdmEfsErrorsInvalidSequence;
                    break;
                case QcdmEfsErrors.DirNotOpen:
                    message = Strings.QcdmEfsErrorsDirNotOpen;
                    break;
                case QcdmEfsErrors.DirEntNotFound:
                    message = Strings.QcdmEfsErrorsDirEntNotFound;
                    break;
                case QcdmEfsErrors.InvalidPath:
                    message = Strings.QcdmEfsErrorsInvalidPath;
                    break;
                case QcdmEfsErrors.PathTooLong:
                    message = Strings.QcdmEfsErrorsPathTooLong;
                    break;
                case QcdmEfsErrors.TooManyOpenDirs:
                    message = Strings.QcdmEfsErrorsTooManyOpenDirs;
                    break;
                case QcdmEfsErrors.InvalidDirEntry:
                    message = Strings.QcdmEfsErrorsInvalidDirEntry;
                    break;
                case QcdmEfsErrors.TooManyOpenFiles:
                    message = Strings.QcdmEfsErrorsTooManyOpenFiles;
                    break;
                case QcdmEfsErrors.UnknownFileType:
                    message = Strings.QcdmEfsErrorsUnknownFileType;
                    break;
                case QcdmEfsErrors.NotNandFlash:
                    message = Strings.QcdmEfsErrorsNotNandFlash;
                    break;
                case QcdmEfsErrors.UnavailableInfo:
                    message = Strings.QcdmEfsErrorsUnavailableInfo;
                    break;
                case QcdmEfsErrors.NotPermited:
                    message = Strings.QcdmEfsErrorsNotPermited;
                    break;
                case QcdmEfsErrors.NoEntry:
                    message = Strings.QcdmEfsErrorsNotEntry;
                    break;
                case QcdmEfsErrors.IoError:
                    message = Strings.QcdmEfsErrorsIoError;
                    break;
                case QcdmEfsErrors.BadFileNumber:
                    message = Strings.QcdmEfsErrorsBadFileNumber;
                    break;
                case QcdmEfsErrors.OutOfMemory:
                    message = Strings.QcdmEfsErrorsOutOfMemory;
                    break;
                case QcdmEfsErrors.PermissionDenided:
                    message = Strings.QcdmEfsErrorsPermissionDenided;
                    break;
                case QcdmEfsErrors.FileExist:
                    message = Strings.QcdmEfsErrorsFileExist;
                    break;
                case QcdmEfsErrors.NotDirectory:
                    message = Strings.QcdmEfsErrorsNotDirectory;
                    break;
                case QcdmEfsErrors.DirectoryNotEmpty:
                    message = Strings.QcdmEfsErrorsDirectoryNotEmpty;
                    break;
                default:
                    message = string.Format(Strings.QcdmEfsErrorsDefaultFormat, error);
                    break;
            }

            return message;
        }

        public static void ThrowQcdmEfsErrorsIfNeed(QcdmEfsErrors error)
        {
            var message = EfsErrorString(error);

            if (message != null)
            {
                throw new QcdmEfsException(message);
            }
        }
    }
}