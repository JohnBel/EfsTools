using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_xdmc_config", false, 0x81FF)]
    [Attributes(9)]
    public class QpImsRcsXdmcConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field2 { get; set; }

        [ElementsCount(1022)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Field3 { get; set; }
    }
}