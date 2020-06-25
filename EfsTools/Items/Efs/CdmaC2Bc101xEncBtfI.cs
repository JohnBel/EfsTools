using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00021998", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc101xEncBtf
    {
        public uint Value { get; set; }
    }
}