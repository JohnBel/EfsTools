using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Access)]
    internal class EfsAccessCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly string _path;
        private readonly byte _permitionBites;

        public EfsAccessCommandRequest(string path, byte permitionBites)
        {
            _path = path;
            _permitionBites = permitionBites;
        }

        public override byte[] GetData()
        {
            var data = new byte[6 + _path.Length];
            data[4] = _permitionBites;
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(Encoding.ASCII.GetBytes(_path), 0, data, 5, _path.Length);
            data[5 + _path.Length] = 0;
            return data;
        }
    }
}