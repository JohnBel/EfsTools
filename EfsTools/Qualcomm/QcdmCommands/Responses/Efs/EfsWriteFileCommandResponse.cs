using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsWrite)]
    [QcdmMinResponseLength(20)]
    internal class EfsWriteFileCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsWriteFileCommandResponse()
        {
        }

        public int BytesWritten { get; private set; }
        public QcdmEfsErrors Error { get; private set; }

        public static EfsWriteFileCommandResponse Parse(byte[] data)
        {
            var result = new EfsWriteFileCommandResponse();
            result.CheckResponse(data);

            //var file = BitConverter.ToInt32(data, 4);
            //var offset = BitConverter.ToUInt32(data, 8); ;
            result.BytesWritten = BitConverter.ToInt32(data, 12);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 16);
            result.Error = error;

            return result;
        }
    }
}