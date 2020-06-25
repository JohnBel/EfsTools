using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024971", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1900RxCalData
    {
        public byte RxCalChanSize { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] RxCalChanList { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public GsmRxFreqCompDataType[] RxFreqCompData { get; set; }
    }
}