using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.Rename)]
    [QcdmMinResponseLength(8)]
    internal class EfsRenameFileCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsRenameFileCommandResponse()
        {
        }

        public static EfsRenameFileCommandResponse Parse(byte[] data)
        {
            var result = new EfsRenameFileCommandResponse();
            result.CheckResponse(data);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 4);
            result.Error = error;
            return result;
        }

        public QcdmEfsErrors Error { get; private set; }
    }
}