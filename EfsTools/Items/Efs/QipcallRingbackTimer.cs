using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/qipcall_ringback_timer", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallRingbackTimer
    {
        public uint Value { get; set; }
    }
}