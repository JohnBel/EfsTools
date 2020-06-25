using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/3gpp2/minapnlist_disallow_call", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class MinapnlistDisallowCall
    {
        public byte Value { get; set; }
    }
}