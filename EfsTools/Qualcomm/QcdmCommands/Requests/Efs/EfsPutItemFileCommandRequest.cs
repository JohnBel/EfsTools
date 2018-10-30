using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Put)]
    internal class EfsPutItemFileCommandRequest : BaseSubSystemCommandRequest, IQcdmCommandRequest
    {
        private readonly byte[] _data;

        private readonly string _fileName;
        private readonly EfsFileFlag _flags;
        private readonly int _permission;

        public EfsPutItemFileCommandRequest(string fileName, EfsFileFlag flags, int permission, byte[] data)
        {
            _fileName = fileName;
            _flags = flags;
            _permission = permission;
            _data = data;
        }

        public new byte[] GetData()
        {
            var data = new byte[25 + _fileName.Length + _data.Length];
            var i = 0;
            Array.Copy(base.GetData(), 0, data, i, 4);
            i += 4;
            Array.Copy(BitConverter.GetBytes(_data.Length), 0, data, i, 2);
            i += 4;

            Array.Copy(BitConverter.GetBytes((int) _flags), 0, data, i, 4);
            i += 4;
            Array.Copy(BitConverter.GetBytes(_permission), 0, data, i, 4);
            i += 2;


            Array.Copy(_data, 0, data, i, _data.Length);
            i += _data.Length;

            Array.Copy(Encoding.ASCII.GetBytes(_fileName), 0, data, i, _fileName.Length);
            i += _fileName.Length;


            data[i] = 0;
            return data;
        }
    }
}