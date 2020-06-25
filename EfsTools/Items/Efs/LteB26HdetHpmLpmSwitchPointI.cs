using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024700", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26HdetHpmLpmSwitchPoint
    {
        public ushort Value { get; set; }
    }
}