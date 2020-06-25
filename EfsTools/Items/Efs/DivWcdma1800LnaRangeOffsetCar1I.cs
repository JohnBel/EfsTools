using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023785", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DivWcdma1800LnaRangeOffsetCar1
    {
        public short Value { get; set; }
    }
}