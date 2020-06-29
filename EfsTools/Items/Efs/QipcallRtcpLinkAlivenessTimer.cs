using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/qipcall_rtcp_link_aliveness_timer", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallRtcpLinkAlivenessTimer
    {
        public uint Value { get; set; }
    }
}