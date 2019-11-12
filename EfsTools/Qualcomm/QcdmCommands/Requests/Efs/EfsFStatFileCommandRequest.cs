using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsFstat)]
    internal class EfsFStatFileCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly int _file;

        public EfsFStatFileCommandRequest(int file)
        {
            _file = file;
        }

        public override byte[] GetData()
        {
            var data = new byte[8];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(_file), 0, data, 4, 4);
            return data;
        }
    }
}