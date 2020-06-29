using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(70213)]
    [EfsFile("/nv/item_files/ims/qipcall_signal_strength_threshold", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallSignalStrengthThreshold
    {
        public short Value { get; set; }
    }
}