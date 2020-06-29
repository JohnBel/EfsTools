using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/data/3gpp/ds_3gpp_mtu", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Ds3gppMtu
    {
        public ushort Value { get; set; }
    }
}