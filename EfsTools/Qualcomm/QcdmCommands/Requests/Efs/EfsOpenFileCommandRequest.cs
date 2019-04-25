using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [Flags]
    internal enum EfsFileFlag
    {
        Readonly = 00000, // open for reading only
        Writeonly = 00001, // open for writing only
        ReadWrite = 00002, // open for reading and writing
        AccessMode = 00003,
        Create = 00100, // create and open file
        Exclude = 00200, // open and truncate
        Truncate = 01000, // open only if file doesn't already exist
        Append = 02000, // writes done at eof
        NoDelay = 04000, //
        Sync = 010000, //
        FaSync = 020000, //
        Direct = 040000, //
        LargeFile = 0100000, //
        Directory = 0200000, //
        NoFollow = 0400000, //
        ItemFile = 01000000, //
        AutoDir = 02000000
    }


    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Open)]
    internal class EfsOpenFileCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly string _fileName;
        private readonly EfsFileFlag _flags;
        private readonly int _permission;

        public EfsOpenFileCommandRequest(string fileName, EfsFileFlag flags, int permission)
        {
            _fileName = fileName;
            _flags = flags;
            _permission = permission;
        }

        public override byte[] GetData()
        {
            var data = new byte[13 + _fileName.Length];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes((int) _flags), 0, data, 4, 4);
            Array.Copy(BitConverter.GetBytes(_permission), 0, data, 8, 4);
            Array.Copy(Encoding.ASCII.GetBytes(_fileName), 0, data, 12, _fileName.Length);
            data[12 + _fileName.Length] = 0;
            return data;
        }
    }
}