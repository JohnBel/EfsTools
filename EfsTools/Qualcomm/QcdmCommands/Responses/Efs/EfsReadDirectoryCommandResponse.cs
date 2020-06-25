using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

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

        public string Name { get; }
        public DirectoryEntryType EntryType { get; }
        public int Mode { get; }
        public int Size { get; }
        public int AccessTime { get; }
        public int ModifyTime { get; }
        public int CreateTime { get; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsReadDir)]
    [QcdmMinResponseLength(40)]
    internal class EfsReadDirectoryCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsReadDirectoryCommandResponse()
        {
        }

        public int Directory { get; private set; }
        public int SequenceNumber { get; private set; }
        public DirectoryEntry DirectoryEntry { get; private set; }
        public QcdmEfsErrors Error { get; private set; }

        public static EfsReadDirectoryCommandResponse Parse(byte[] data)
        {
            var result = new EfsReadDirectoryCommandResponse();
            result.CheckResponse(data);

            result.Directory = BitConverter.ToInt32(data, 4);
            result.SequenceNumber = BitConverter.ToInt32(data, 8);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 12);
            result.Error = error;

            var entryType = (DirectoryEntryType) BitConverter.ToInt32(data, 16);
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
    }
}