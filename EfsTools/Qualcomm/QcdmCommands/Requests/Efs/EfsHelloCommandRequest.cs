using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Hello)]
    internal class EfsHelloCommandRequest : BaseSubSystemCommandRequest
    {
        private const uint EfsDefaultWindowSize = 0x100000;
        private const uint EfsDefaultWindowByteSize = 0x100000;
        private const uint EfsVersion = 0x0001;
        private const uint EfsMinVersion = 0x0001;
        private const uint EfsMaxVersion = 0x0001;

        public override byte[] GetData()
        {
            var data = new byte[44];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(EfsDefaultWindowSize), 0, data, 4, 4);
            Array.Copy(BitConverter.GetBytes(EfsDefaultWindowByteSize), 0, data, 8, 4);
            Array.Copy(BitConverter.GetBytes(EfsDefaultWindowSize), 0, data, 12, 4);
            Array.Copy(BitConverter.GetBytes(EfsDefaultWindowByteSize), 0, data, 16, 4);
            Array.Copy(BitConverter.GetBytes(EfsDefaultWindowSize), 0, data, 20, 4);
            Array.Copy(BitConverter.GetBytes(EfsDefaultWindowByteSize), 0, data, 24, 4);
            Array.Copy(BitConverter.GetBytes(EfsVersion), 0, data, 28, 4);
            Array.Copy(BitConverter.GetBytes(EfsMinVersion), 0, data, 32, 4);
            Array.Copy(BitConverter.GetBytes(EfsMaxVersion), 0, data, 36, 4);
            data[40] = 0xFF;
            data[41] = 0xFF;
            data[42] = 0xFF;
            data[43] = 0xFF;
            return data;
        }
    }
}