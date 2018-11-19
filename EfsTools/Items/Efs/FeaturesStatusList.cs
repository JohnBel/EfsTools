using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [NvItemId(73763)]
    [EfsFile("/nv/item_files/modem/uim/mmgsdi/features_status_list", true, 0xE1FF)]
    [Attributes(9)]
    public class FeaturesStatusList
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }
        
        [ElementsCount(63)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}