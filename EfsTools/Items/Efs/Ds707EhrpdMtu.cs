using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/data/1x/707/ds707_ehrpd_mtu", true, 0xE1FF)]
    [Attributes(9)]
    public class Ds707EhrpdMtu
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }
    }
}