using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(67233)]
    [EfsFile("/nv/item_files/ims/ims_rtp_loop_back_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ImsRtpLoopBackEnabled
    {
        public byte Value { get; set; }
    }
}