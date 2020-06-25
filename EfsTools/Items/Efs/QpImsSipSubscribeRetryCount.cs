using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(71580)]
    [EfsFile("/nv/item_files/ims/qp_ims_sip_subscribe_retry_count", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsSipSubscribeRetryCount
    {
        public byte Value { get; set; }
    }
}