using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort)QcdmEfsCommand.SyncNoWait)]
    internal class EfsSyncNoWaitCommandRequest : BaseSubSystemCommandRequest, IQcdmCommandRequest
    {
        public EfsSyncNoWaitCommandRequest(string path, ushort sequence)
        {
            _path = path;
            _sequence = sequence;
        }

        public new byte[] GetData()
        {
            var data = new byte[7 + _path.Length];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(_sequence), 0, data, 4, 2);
            Array.Copy(Encoding.ASCII.GetBytes(_path), 0, data, 6, _path.Length);
            data[6 + _path.Length] = 0;
            return data;
        }

        private readonly string _path;
        private readonly ushort _sequence;
    }
}