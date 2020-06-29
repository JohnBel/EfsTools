using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [NvItemId(73687)]
    [EfsFile("/nv/item_files/ims/qp_ims_rcs_xdmc_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsRcsXdmcConfig
    {
        [Required]
        public byte Version { get; set; }


        public byte DisableXdmc { get; set; }

        [FieldCount(1022)]
        public byte[] Reserved { get; set; }
    }
}