using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(73713)]
    [EfsFile("/nv/item_files/ims/ims_rat_ho_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ImsRatHoConfig
    {
        [Required]
        public byte Version { get; set; }


        public uint ImsHoHystTimerEpdgLte { get; set; }


        public uint ImsHoHystTimerEpdg1x { get; set; }


        public uint ImsHoHystTimerEpdgWifi { get; set; }


        public byte ImsHoEnabled { get; set; }
    }
}