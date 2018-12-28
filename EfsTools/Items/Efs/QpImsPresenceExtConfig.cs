using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71542)]
    [EfsFile("/nv/item_files/ims/qp_ims_presence_ext_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsPresenceExtConfig
    {
        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint PublishErrorRecoveryTimer { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte EnableModemPresence { get; set; }


        [ElementsCount(122)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserved { get; set; }
    }
}