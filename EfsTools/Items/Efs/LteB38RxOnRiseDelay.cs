using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022384", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB38RxOnRiseDelay
    {
        public ushort Value { get; set; }
    }
}