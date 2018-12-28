using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(73545)]
    [EfsFile("/nv/item_files/modem/mmode/wifi_config", true, 0xE1FF)]
    [Attributes(9)]
    public class WifiConfig
    {
        [Required]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Version { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IsWifiOnlyModeForVoice { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte IsE911OverWifi { get; set; }

        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte WifiCsScanTimer { get; set; }
        
        
        [ElementsCount(7)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Reserved { get; set; }
    }
}