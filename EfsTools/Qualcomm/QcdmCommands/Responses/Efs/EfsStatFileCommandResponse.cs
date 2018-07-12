using System;
using System.Dynamic;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    internal class FileStat
    {
        public FileStat(
            int mode,
            int size,
            int linkCount,
            int atime,
            int mtime,
            int ctime
        )
        {
            Mode = mode;
            Size = size;
            LinkCount = linkCount;
            AccessTime = atime;
            ModifyTime = mtime;
            CreateTime = ctime;
        }

        public int Mode { get; private set; }
        public int Size { get; private set; }
        public int LinkCount { get; private set; }
        public int AccessTime { get; private set; }
        public int ModifyTime { get; private set; }
        public int CreateTime { get; private set; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.Stat)]
    [QcdmMinResponseLength(32)]
    internal class EfsStatFileCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsStatFileCommandResponse()
        {
        }

        public static EfsStatFileCommandResponse Parse(byte[] data)
        {
            var result = new EfsStatFileCommandResponse();
            result.CheckResponse(data);

            var mode = BitConverter.ToInt32(data, 8); 
            var size = BitConverter.ToInt32(data, 12);
            var linkCount = BitConverter.ToInt32(data, 16);
            var atime = BitConverter.ToInt32(data, 20);
            var mtime = BitConverter.ToInt32(data, 24);
            var ctime = BitConverter.ToInt32(data, 28);
            result.Stat = new FileStat(mode, size, linkCount, atime, mtime, ctime);
            return result;
        }

        public FileStat Stat { get; private set; }
    }
}