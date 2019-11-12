using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsOpenDir)]
    [QcdmMinResponseLength(12)]
    internal class EfsOpenDirectoryCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsOpenDirectoryCommandResponse()
        {
        }

        public int Directory { get; private set; }
        public bool IsError { get; private set; }
        public QcdmEfsErrors Error { get; private set; }

        public static EfsOpenDirectoryCommandResponse Parse(byte[] data)
        {
            var result = new EfsOpenDirectoryCommandResponse();
            result.CheckResponse(data);

            var dir = BitConverter.ToInt32(data, 4);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 8);
            result.IsError = dir < 0;
            result.Error = error;
            result.Directory = dir;
            return result;
        }
    }
}