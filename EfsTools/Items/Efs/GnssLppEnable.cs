using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/gps/cgps/sm/gnss_lpp_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GnssLppEnable
    {
        public byte Value { get; set; }
    }
}