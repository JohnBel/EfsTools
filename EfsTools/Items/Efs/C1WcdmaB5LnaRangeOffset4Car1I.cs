using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022562", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaB5LnaRangeOffset4Car1
    {
        public short Value { get; set; }
    }
}