using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/gps/cgps/sm/gnss_lpp_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GnssLppEnable
    {
        public byte Value { get; set; }
    }
}