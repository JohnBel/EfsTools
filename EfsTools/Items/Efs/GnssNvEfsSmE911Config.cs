using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/gps/cgps/sm/gnss_nv_efs_sm_e911_config", true, 0xE1FF)]
    [Attributes(9)]
    public class GnssNvEfsSmE911Config
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
    }
}