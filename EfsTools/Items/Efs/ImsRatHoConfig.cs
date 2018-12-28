using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(73713)]
    [EfsFile("/nv/item_files/ims/ims_rat_ho_config", true, 0xE1FF)]
    [Attributes(9)]
    public class ImsRatHoConfig
    {
        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint ImsHoHystTimerEpdgLte { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint ImsHoHystTimerEpdg1x { get; set; }

        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint ImsHoHystTimerEpdgWifi { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ImsHoEnabled { get; set; }
    }
}