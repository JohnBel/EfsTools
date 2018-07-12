using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests
{
    [QcdmCommand(QcdmCommand.NvRead)]
    internal class NvReadCommandRequest : BaseCommandRequest, IQcdmCommandRequest
    {
        public NvReadCommandRequest(ushort itemId)
        {
            _itemId = itemId;
        }

        public new byte[] GetData()
        {
            var data = new byte[131];
            data[0] = (byte) Command;
            Array.Copy(BitConverter.GetBytes(_itemId), 0, data, 1, 2);
            return data;
        }

        private readonly ushort _itemId;
    }
}