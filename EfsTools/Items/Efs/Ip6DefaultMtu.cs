using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/datamodem/protocols/ip6_default_mtu", true, 0xE1FF)]
    [Attributes(9)]
    public class Ip6DefaultMtu
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }
    }
}