using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71580)]
    [EfsFile("/nv/item_files/ims/qp_ims_sip_subscribe_retry_count", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsSipSubscribeRetryCount
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}