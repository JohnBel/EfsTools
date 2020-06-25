using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/3gpp/ds_3gpp_mtu", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Ds3gppMtu
    {
        public ushort Value { get; set; }
    }
}