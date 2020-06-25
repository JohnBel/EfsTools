using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/datamodem/protocols/ip6_default_mtu", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Ip6DefaultMtu
    {
        public ushort Value { get; set; }
    }
}