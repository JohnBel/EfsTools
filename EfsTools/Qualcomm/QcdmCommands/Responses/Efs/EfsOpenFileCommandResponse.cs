using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Open)]
    [QcdmMinResponseLength(12)]
    internal class EfsOpenFileCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsOpenFileCommandResponse()
        {
        }

        public int File { get; private set; }
        public bool IsError { get; private set; }
        public QcdmEfsErrors Error { get; private set; }

        public static EfsOpenFileCommandResponse Parse(byte[] data)
        {
            var result = new EfsOpenFileCommandResponse();
            result.CheckResponse(data);

            var file = BitConverter.ToInt32(data, 4);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 8);
            result.IsError = file < 0;
            result.Error = error;
            result.File = file;
            return result;
        }
    }
}