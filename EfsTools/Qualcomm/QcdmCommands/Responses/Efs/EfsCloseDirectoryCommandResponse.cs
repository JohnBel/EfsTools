using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.CloseDir)]
    [QcdmMinResponseLength(8)]
    internal class EfsCloseDirectoryCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsCloseDirectoryCommandResponse()
        {
        }

        public QcdmEfsErrors Error { get; private set; }

        public static EfsCloseDirectoryCommandResponse Parse(byte[] data)
        {
            var result = new EfsCloseDirectoryCommandResponse();
            result.CheckResponse(data);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 4);
            result.Error = error;
            return result;
        }
    }
}