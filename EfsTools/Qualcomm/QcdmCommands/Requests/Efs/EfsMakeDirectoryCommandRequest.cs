using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsMkdir)]
    internal class EfsMakeDirectoryCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly ushort _mode;
        private readonly string _name;

        public EfsMakeDirectoryCommandRequest(ushort mode, string name)
        {
            _mode = mode;
            _name = name;
        }

        public override byte[] GetData()
        {
            var data = new byte[7 + _name.Length];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(_mode), 0, data, 4, 2);
            Array.Copy(Encoding.ASCII.GetBytes(_name), 0, data, 6, _name.Length);
            data[6 + _name.Length] = 0;
            return data;
        }
    }
}