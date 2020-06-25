using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/gps/cgps/sm/gnss_agps_rat_pref_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GnssAgpsRatPrefConfig
    {
        public byte Field1 { get; set; }


        public ushort Field2 { get; set; }
    }
}