using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023726", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteGnssBlankingRiseFallDelta
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public short[] RiseDelay { get; set; }
    }
}