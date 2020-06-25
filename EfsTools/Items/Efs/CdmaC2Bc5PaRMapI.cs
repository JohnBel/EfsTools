using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00021897", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc5PaRMap
    {
        public byte Value { get; set; }
    }
}