using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/datamodem/protocols/ip6_default_mtu", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Ip6DefaultMtu
    {
        public ushort Value { get; set; }
    }
}