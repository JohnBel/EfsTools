using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/nv/item_files/ims/qipcall_is_conf_server_refer_recipient", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallIsConfServerReferRecipient
    {
        public byte Value { get; set; }
    }
}