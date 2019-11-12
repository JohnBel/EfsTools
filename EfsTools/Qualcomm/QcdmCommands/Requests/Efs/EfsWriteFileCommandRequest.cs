using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsWrite)]
    internal class EfsWriteFileCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly byte[] _data;
        private readonly int _dataCount;
        private readonly int _dataOffset;

        private readonly int _file;
        private readonly uint _offset;

        public EfsWriteFileCommandRequest(int file, uint offset, byte[] data, int dataOffset, int dataCount)
        {
            _file = file;
            _offset = offset;
            _data = data;
            _dataOffset = dataOffset;
            _dataCount = dataCount;
        }

        public override byte[] GetData()
        {
            var data = new byte[12 + _dataCount];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(_file), 0, data, 4, 4);
            Array.Copy(BitConverter.GetBytes(_offset), 0, data, 8, 4);
            Array.Copy(_data, _dataOffset, data, 12, _dataCount);
            return data;
        }
    }
}