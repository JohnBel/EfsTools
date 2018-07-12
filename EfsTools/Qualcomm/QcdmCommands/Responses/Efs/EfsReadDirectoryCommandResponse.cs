using System;
using System.Dynamic;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    internal enum DirectoryEntryType
    {
        File = 0,
        Directory = 1,
        Link = 2,
        Immovable = 3,
        ItemFile = 15
    }

    internal class DirectoryEntry
    {
        public DirectoryEntry(
            string name,
            DirectoryEntryType entryType,
            int mode,
            int size,
            int atime,
            int mtime,
            int ctime
        )
        {
            Name = name;
            EntryType = entryType;
            Mode = mode;
            Size = size;
            AccessTime = atime;
            ModifyTime = mtime;
            CreateTime = ctime;
        }

        public string Name { get; private set; }
        public DirectoryEntryType EntryType { get; private set; }
        public int Mode { get; private set; }
        public int Size { get; private set; }
        public int AccessTime { get; private set; }
        public int ModifyTime { get; private set; }
        public int CreateTime { get; private set; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.ReadDir)]
    [QcdmMinResponseLength(40)]
    internal class EfsReadDirectoryCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsReadDirectoryCommandResponse()
        {
        }

        public static EfsReadDirectoryCommandResponse Parse(byte[] data)
        {
            var result = new EfsReadDirectoryCommandResponse();
            result.CheckResponse(data);

            result.Directory = BitConverter.ToInt32(data, 4);
            result.SequenceNumber = BitConverter.ToInt32(data, 8);
            var error = (QcdmEfsErrors)BitConverter.ToInt32(data, 12);
            result.Error = error;

            var entryType = (DirectoryEntryType)BitConverter.ToInt32(data, 16);
            var mode = BitConverter.ToInt32(data, 20);
            var size = BitConverter.ToInt32(data, 24);
            var atime = BitConverter.ToInt32(data, 28);
            var mtime = BitConverter.ToInt32(data, 32);
            var ctime = BitConverter.ToInt32(data, 36);
            var nameLength = data.Length - 41;
            if (nameLength < 0)
            {
                nameLength = 0;
            }
            var name = Encoding.ASCII.GetString(data, 40, nameLength);
            result.DirectoryEntry = new DirectoryEntry(name, entryType, mode, size, atime, mtime, ctime);
            return result;
        }

        public int Directory { get; private set; }
        public int SequenceNumber { get; private set; }
        public DirectoryEntry DirectoryEntry { get; private set; }
        public QcdmEfsErrors Error { get; private set; }
    }
}