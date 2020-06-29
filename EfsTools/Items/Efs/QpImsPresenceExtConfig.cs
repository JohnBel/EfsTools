using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71542)]
    [EfsFile("/nv/item_files/ims/qp_ims_presence_ext_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsPresenceExtConfig
    {
        [Required]
        public byte Version { get; set; }


        public uint PublishErrorRecoveryTimer { get; set; }


        public byte EnableModemPresence { get; set; }


        [FieldCount(122)]
        public byte[] Reserved { get; set; }
    }
}