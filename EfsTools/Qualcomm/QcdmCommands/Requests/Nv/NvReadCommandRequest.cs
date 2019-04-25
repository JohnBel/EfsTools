using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Nv
{
    [QcdmCommand(QcdmCommand.NvRead)]
    internal class NvReadCommandRequest : BaseCommandRequest
    {
        private readonly ushort _itemId;

        public NvReadCommandRequest(ushort itemId)
        {
            _itemId = itemId;
        }

        public override byte[] GetData()
        {
            var data = new byte[131];
            data[0] = (byte) Command;
            Array.Copy(BitConverter.GetBytes(_itemId), 0, data, 1, 2);
            return data;
        }
    }
}