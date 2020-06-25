using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/1x/707/ds707_ehrpd_mtu", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Ds707EhrpdMtu
    {
        public ushort Value { get; set; }
    }
}