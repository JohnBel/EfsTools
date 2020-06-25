using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00020800", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB5MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}