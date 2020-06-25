using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(73545)]
    [EfsFile("/nv/item_files/modem/mmode/wifi_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WifiConfig
    {
        [Required]
        public byte Version { get; set; }


        public byte IsWifiOnlyModeForVoice { get; set; }


        public byte IsE911OverWifi { get; set; }


        public byte WifiCsScanTimer { get; set; }


        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Reserved { get; set; }
    }
}