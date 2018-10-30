using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/get_net_auto_mode", true, 0xE1FF)]
    [Attributes(9)]
    public class GetNetAutoMode
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Reserved { get; set; }
    }
}