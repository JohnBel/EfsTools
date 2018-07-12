using System;
using System.Dynamic;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.Put)]
    [QcdmMinResponseLength(10)]
    internal class EfsPutItemFileCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsPutItemFileCommandResponse()
        {
        }

        public static EfsPutItemFileCommandResponse Parse(byte[] data)
        {
            var result = new EfsPutItemFileCommandResponse();
            result.CheckResponse(data);
            result.Permissions = BitConverter.ToInt16(data, 4);
            result.Error = (QcdmEfsErrors)BitConverter.ToInt16(data, 6);
            result.BytesWritten = BitConverter.ToInt16(data, 8);
            return result;
        }

        public short Permissions { get; private set; }
        public int BytesWritten { get; private set; }
        public QcdmEfsErrors Error { get; private set; }
    }
}