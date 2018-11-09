using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(71581)]
    [EfsFile("/nv/item_files/ims/qp_ims_wifi_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsWifiConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int RssiThresholdAdd { get; set; }

        [ElementsCount(1)]
        [ElementType("int32")]
        [Description("")]
        public int RssiThresholdDrop { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RssiAvgTimerOnAttach { get; set; }

        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RssiAvgTimerOnCamp { get; set; }
    }
}