using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/gps/cgps/sm/gnss_nv_efs_sm_e911_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GnssNvEfsSmE911Config
    {
        public uint Value { get; set; }
    }
}