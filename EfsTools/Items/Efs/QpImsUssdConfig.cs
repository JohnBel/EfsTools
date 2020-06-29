using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [Subscription]
    [NvItemId(71540)]
    [EfsFile("/nv/item_files/ims/qp_ims_ussd_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsUssdConfig
    {
        [Required]
        public byte Version { get; set; }


        public byte UssdEnable { get; set; }

        [FieldCount(509)]
        public byte[] Reserved { get; set; }
    }
}