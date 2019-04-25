using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Unlink)]
    internal class EfsUnlinkFileCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly string _path;

        public EfsUnlinkFileCommandRequest(string path)
        {
            _path = path;
        }

        public override byte[] GetData()
        {
            var data = new byte[5 + _path.Length];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(Encoding.ASCII.GetBytes(_path), 0, data, 4, _path.Length);
            data[4 + _path.Length] = 0;
            return data;
        }
    }
}