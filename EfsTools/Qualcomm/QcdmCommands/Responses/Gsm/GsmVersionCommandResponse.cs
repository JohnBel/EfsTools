using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Gsm
{
    internal class GsmVersion
    {
        public GsmVersion(UInt16 vDspVersion,
            UInt16 mdspVersionRom,
            UInt16 mdspVersionRam)
        {
            VocorerDspVersion = vDspVersion;
            MdspVersionRom = mdspVersionRom;
            MdspVersionRam = mdspVersionRam;
        }

        public UInt16 VocorerDspVersion { get; private set; }
        public UInt16 MdspVersionRom { get; private set; }
        public UInt16 MdspVersionRam { get; private set; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Gsm, 0)]
    [QcdmMinResponseLength(10)]
    internal class GsmVersionCommandResponse : BaseSubSystemCommandResponse
    {
        private GsmVersionCommandResponse()
        {
        }

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

        public GsmVersion Version { get; private set; }
    }
}