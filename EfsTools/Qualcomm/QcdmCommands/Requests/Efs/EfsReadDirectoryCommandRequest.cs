using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsReadDir)]
    internal class EfsReadDirectoryCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly int _directory;
        private readonly int _sequenceNumber;

        public EfsReadDirectoryCommandRequest(int dir, int sequenceNumber)
        {
            _directory = dir;
            _sequenceNumber = sequenceNumber;
        }

        public override byte[] GetData()
        {
            var data = new byte[12];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(_directory), 0, data, 4, 4);
            Array.Copy(BitConverter.GetBytes(_sequenceNumber), 0, data, 8, 4);
            return data;
        }
    }
}