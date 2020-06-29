using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/gps/cgps/sm/gnss_agps_rat_pref_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GnssAgpsRatPrefConfig
    {
        public byte Field1 { get; set; }


        public ushort Field2 { get; set; }
    }
}