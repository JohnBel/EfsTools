using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(73687)]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_xdmc_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsRcsXdmcConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DisableXdmc { get; set; }

        [ElementsCount(1022)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserved { get; set; }
    }
}