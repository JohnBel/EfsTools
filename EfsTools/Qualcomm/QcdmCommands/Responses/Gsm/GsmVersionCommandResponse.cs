using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Gsm
{
    internal class GsmVersion
    {
        public GsmVersion(ushort vDspVersion,
            ushort mdspVersionRom,
            ushort mdspVersionRam)
        {
            VocorerDspVersion = vDspVersion;
            MdspVersionRom = mdspVersionRom;
            MdspVersionRam = mdspVersionRam;
        }

        public ushort VocorerDspVersion { get; }
        public ushort MdspVersionRom { get; }
        public ushort MdspVersionRam { get; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Gsm, 0)]
    [QcdmMinResponseLength(10)]
    internal class GsmVersionCommandResponse : BaseSubSystemCommandResponse
    {
        private GsmVersionCommandResponse()
        {
        }

        public GsmVersion Version { get; private set; }

        public static GsmVersionCommandResponse Parse(byte[] data)
        {
            var result = new GsmVersionCommandResponse();
            result.CheckResponse(data);

            var vDspVersion = BitConverter.ToUInt16(data, 4);
            var mdspVersionRom = BitConverter.ToUInt16(data, 6);
            var mdspVersionRam = BitConverter.ToUInt16(data, 8);
            result.Version = new GsmVersion(vDspVersion, mdspVersionRom, mdspVersionRam);

            return result;
        }
    }
}