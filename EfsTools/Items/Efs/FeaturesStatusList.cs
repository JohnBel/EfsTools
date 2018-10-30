using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/uim/mmgsdi/features_status_list", true, 0xE1FF)]
    [Attributes(9)]
    public class FeaturesStatusList
    {
        [ElementsCount(64)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}