using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00020920", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C1Wcdma1900LnaRangeFall4Car1
    {
        public short Value { get; set; }
    }
}