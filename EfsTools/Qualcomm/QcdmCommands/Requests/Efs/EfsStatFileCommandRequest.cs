using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Stat)]
    internal class EfsStatFileCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly string _fileName;

        public EfsStatFileCommandRequest(string fileName)
        {
            _fileName = fileName;
        }

        public override byte[] GetData()
        {
            var data = new byte[5 + _fileName.Length];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(Encoding.ASCII.GetBytes(_fileName), 0, data, 4, _fileName.Length);
            data[4 + _fileName.Length] = 0;
            return data;
        }
    }
}