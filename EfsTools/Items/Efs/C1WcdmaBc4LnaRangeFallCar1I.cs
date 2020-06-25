using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00020977", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4LnaRangeFallCar1
    {
        public short Value { get; set; }
    }
}