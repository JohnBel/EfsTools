using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Nv
{
    [QcdmCommand(QcdmCommand.NvWrite)]
    internal class NvWriteCommandRequest : BaseCommandRequest
    {
        private readonly byte[] _data;

        private readonly ushort _itemId;

        public NvWriteCommandRequest(ushort itemId, byte[] data)
        {
            _itemId = itemId;
            _data = data;
        }

        public override byte[] GetData()
        {
            var size = 3 + _data.Length;
            var data = new byte[size];
            data[0] = (byte) Command;
            Array.Copy(BitConverter.GetBytes(_itemId), 0, data, 1, 2);
            Array.Copy(_data, 0, data, 3, _data.Length);
            return data;
        }
    }
}