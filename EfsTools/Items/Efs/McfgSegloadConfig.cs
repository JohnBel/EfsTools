using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/mcfg/mcfg_segload_config", true, 0xE1FF)]
    [Attributes(9)]
    public class McfgSegloadConfig
    {
        [Required]
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Version { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
    }
}