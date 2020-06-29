using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/gps/cgps/sm/gnss_1x_up_supl_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gnss1xUpSuplEnable
    {
        public byte Value { get; set; }
    }
}