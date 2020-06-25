using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/hdr/cp/ovhd/d2lresel", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class D2lresel
    {
        public byte Value { get; set; }
    }
}