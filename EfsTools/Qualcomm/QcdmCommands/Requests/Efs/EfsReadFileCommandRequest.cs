using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Read)]
    internal class EfsReadFileCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly int _file;
        private readonly uint _offset;
        private readonly uint _size;

        public EfsReadFileCommandRequest(int file, uint size, uint offset)
        {
            _file = file;
            _size = size;
            _offset = offset;
        }

        public override byte[] GetData()
        {
            var data = new byte[16];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(_file), 0, data, 4, 4);
            Array.Copy(BitConverter.GetBytes(_size), 0, data, 8, 4);
            Array.Copy(BitConverter.GetBytes(_offset), 0, data, 12, 4);
            return data;
        }
    }
}