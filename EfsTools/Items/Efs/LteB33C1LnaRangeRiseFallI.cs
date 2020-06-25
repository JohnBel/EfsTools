using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024887", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C1LnaRangeRiseFall
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public short[] C1LnaRangeRiseFallType { get; set; }
    }
}