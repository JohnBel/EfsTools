using System;
using System.Dynamic;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.Fstat)]
    [QcdmMinResponseLength(32)]
    internal class EfsFStatFileCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsFStatFileCommandResponse()
        {
        }

        public static EfsFStatFileCommandResponse Parse(byte[] data)
        {
            var result = new EfsFStatFileCommandResponse();
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