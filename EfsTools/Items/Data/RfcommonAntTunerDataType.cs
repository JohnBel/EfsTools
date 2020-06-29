using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfcommonAntTunerDataType
    {
        [FieldCount(4)]
        public byte[] DeviceEnable
        {
            get;
        }

        [FieldCount(4)]
        public byte[] DeviceCs
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] ChannelList
        {
            get;
        }

        [FieldCount(64)]
        public uint[] CodeWords
        {
            get;
        }
    }
}