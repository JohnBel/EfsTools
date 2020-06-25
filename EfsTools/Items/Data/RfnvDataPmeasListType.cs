using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class RfnvDataPmeasListType
    {
        public byte Mod { get; set; }


        public byte ChannelIndex { get; set; }


        public byte PaState { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public short[] PmeasList
        {
            get;
        }
    }
}