using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/data/dsd/ds_apn_switching", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DsApnSwitching
    {
        public byte Value { get; set; }
    }
}