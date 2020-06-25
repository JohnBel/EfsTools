using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfcommonAntTunerDataType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] DeviceEnable
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] DeviceCs
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] ChannelList
        {
            get;
        }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] CodeWords
        {
            get;
        }
    }
}