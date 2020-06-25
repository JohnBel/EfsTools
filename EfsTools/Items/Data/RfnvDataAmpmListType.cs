using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfnvDataAmpmListType
    {
        public byte AmamAmpmIdentifier { get; set; }


        public byte ChannelIndex { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public short[] DataList
        {
            get;
        }
    }
}