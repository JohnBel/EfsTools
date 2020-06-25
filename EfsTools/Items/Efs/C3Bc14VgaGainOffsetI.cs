using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023351", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C3Bc14VgaGainOffset
    {
        public short Value { get; set; }
    }
}