using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00020936", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma900LnaRangeRise5Car1
    {
        public short Value { get; set; }
    }
}