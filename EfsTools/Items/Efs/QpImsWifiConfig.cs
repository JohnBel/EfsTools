using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [NvItemId(71581)]
    [EfsFile("/nv/item_files/ims/qp_ims_wifi_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QpImsWifiConfig
    {
        [Required]
        public byte Version { get; set; }


        public int RssiThresholdAdd { get; set; }


        public int RssiThresholdDrop { get; set; }


        public ushort RssiAvgTimerOnAttach { get; set; }


        public ushort RssiAvgTimerOnCamp { get; set; }
    }
}