using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsMkdir)]
    [QcdmMinResponseLength(8)]
    internal class EfsMakeDirectoryCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsMakeDirectoryCommandResponse()
        {
        }

        public QcdmEfsErrors Error { get; private set; }

        public static EfsMakeDirectoryCommandResponse Parse(byte[] data)
        {
            var result = new EfsMakeDirectoryCommandResponse();
            result.CheckResponse(data);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 4);
            result.Error = error;
            return result;
        }
    }
}