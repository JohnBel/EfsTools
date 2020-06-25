using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023564", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB39LnaRangeRiseFall
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public short[] Value { get; set; }
    }
}