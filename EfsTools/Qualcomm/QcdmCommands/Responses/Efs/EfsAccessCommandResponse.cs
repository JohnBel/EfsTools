using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsAccess)]
    [QcdmMinResponseLength(8)]
    internal class EfsAccessCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsAccessCommandResponse()
        {
        }

        public QcdmEfsErrors Error { get; private set; }

        public static EfsAccessCommandResponse Parse(byte[] data)
        {
            var result = new EfsAccessCommandResponse();
            result.CheckResponse(data);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 4);
            result.Error = error;
            return result;
        }
    }
}