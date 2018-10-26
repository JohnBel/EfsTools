using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Nv
{
    [QcdmCommand(QcdmCommand.NvRead)]
    [QcdmMinResponseLength(133)]
    internal class NvReadCommandResponse : BaseCommandResponse, IQcdmCommandResponse
    {
        private NvReadCommandResponse()
        {
        }

        public static NvReadCommandResponse Parse(byte[] data)
        {
            var result = new NvReadCommandResponse();
            result.CheckResponse(data);

            result.ItemId = BitConverter.ToUInt16(data, 1);
            result.Data = new byte[128];
            Array.Copy(data, 3, result.Data, 0, 128);
            return result;
        }

        public ushort ItemId { get; private set; }
        public byte[] Data { get; private set; }
    }
}