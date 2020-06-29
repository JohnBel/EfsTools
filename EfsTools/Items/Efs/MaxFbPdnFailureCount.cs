using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp2/max_fb_pdn_failure_count", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class MaxFbPdnFailureCount
    {
        public byte Value { get; set; }
    }
}