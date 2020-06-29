using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/qipcall_rtp_link_aliveness_timer", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallRtpLinkAlivenessTimer
    {
        public uint Value { get; set; }
    }
}