using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    internal class HelloInfo
    {
        public HelloInfo(
            int targetPacketWindowSize,
            int targetPacketWindowByteSize,
            int hostPacketWindowSize,
            int hostPacketWindowByteSize,
            int dirIteratorWindowSize,
            int dirIteratorWindowByteSize,
            int version,
            int minVersion,
            int maxVersion,
            int featureBits
        )
        {
            TargetPacketWindowSize = targetPacketWindowSize;
            TargetPacketWindowByteSize = targetPacketWindowByteSize;
            HostPacketWindowSize = hostPacketWindowSize;
            HostPacketWindowByteSize = hostPacketWindowByteSize;
            DirIteratorWindowSize = dirIteratorWindowSize;
            DirIteratorWindowByteSize = dirIteratorWindowByteSize;
            Version = version;
            MinVersion = minVersion;
            MaxVersion = maxVersion;
            FeatureBits = featureBits;
        }

        public int TargetPacketWindowSize { get; }
        public int TargetPacketWindowByteSize { get; }
        public int HostPacketWindowSize { get; }
        public int HostPacketWindowByteSize { get; }
        public int DirIteratorWindowSize { get; }
        public int DirIteratorWindowByteSize { get; }
        public int Version { get; }
        public int MinVersion { get; }
        public int MaxVersion { get; }
        public int FeatureBits { get; }
    }

    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.Hello)]
    [QcdmMinResponseLength(44)]
    internal class EfsHelloCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsHelloCommandResponse()
        {
        }

        public HelloInfo Info { get; private set; }

        public static EfsHelloCommandResponse Parse(byte[] data)
        {
            var result = new EfsHelloCommandResponse();
            result.CheckResponse(data);

            var targetPacketWindowSize = BitConverter.ToInt32(data, 4);
            var targetPacketWindowByteSize = BitConverter.ToInt32(data, 8);
            var hostPacketWindowSize = BitConverter.ToInt32(data, 12);
            var hostPacketWindowByteSize = BitConverter.ToInt32(data, 16);
            var dirIteratorWindowSize = BitConverter.ToInt32(data, 20);
            var dirIteratorWindowByteSize = BitConverter.ToInt32(data, 24);
            var version = BitConverter.ToInt32(data, 28);
            var minVersion = BitConverter.ToInt32(data, 32);
            var maxVersion = BitConverter.ToInt32(data, 36);
            var featureBits = BitConverter.ToInt32(data, 40);
            result.Info = new HelloInfo(targetPacketWindowSize, targetPacketWindowByteSize, hostPacketWindowSize,
                hostPacketWindowByteSize, dirIteratorWindowSize, dirIteratorWindowByteSize,
                version, minVersion, maxVersion, featureBits);
            return result;
        }
    }
}