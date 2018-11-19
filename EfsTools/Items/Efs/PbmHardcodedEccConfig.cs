using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(69736)]
    [EfsFile("/nv/item_files/pbm/pbm_hardcoded_ecc_config", true, 0xE1FF)]
    [Attributes(9)]
    public class PbmHardcodedEccConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}