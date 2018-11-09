using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71540)]
    [EfsFile("/nv/item_files/ims/qp_ims_ussd_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsUssdConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte UssdEnable { get; set; }

        [Optional]
        [ElementsCount(509)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserved { get; set; }
    }
}