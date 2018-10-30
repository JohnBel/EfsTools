using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qipcall_rtcp_link_aliveness_timer", true, 0xE1FF)]
    [Attributes(9)]
    public class QipcallRtcpLinkAlivenessTimer
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
    }
}