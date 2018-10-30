using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Nv
{
    [QcdmCommand(QcdmCommand.NvWrite)]
    [QcdmMinResponseLength(3)]
    internal class NvWriteCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private NvWriteCommandResponse()
        {
        }

        public ushort Code { get; private set; }

        public static NvWriteCommandResponse Parse(byte[] data)
        {
            var result = new NvWriteCommandResponse();
            result.CheckResponse(data);
            result.Code = BitConverter.ToUInt16(data, 1);
            return result;
        }
    }
}