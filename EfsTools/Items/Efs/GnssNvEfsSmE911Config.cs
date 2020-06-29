using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/gps/cgps/sm/gnss_nv_efs_sm_e911_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GnssNvEfsSmE911Config
    {
        public uint Value { get; set; }
    }
}