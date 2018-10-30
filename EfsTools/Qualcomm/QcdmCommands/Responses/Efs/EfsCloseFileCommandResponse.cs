using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Close)]
    [QcdmMinResponseLength(8)]
    internal class EfsCloseFileCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsCloseFileCommandResponse()
        {
        }

        public QcdmEfsErrors Error { get; private set; }

        public static EfsCloseFileCommandResponse Parse(byte[] data)
        {
            var result = new EfsCloseFileCommandResponse();
            result.CheckResponse(data);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 4);
            result.Error = error;
            return result;
        }
    }
}