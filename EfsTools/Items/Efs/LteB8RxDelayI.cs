using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00020847", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB8RxDelay
    {
        public short Value { get; set; }
    }
}