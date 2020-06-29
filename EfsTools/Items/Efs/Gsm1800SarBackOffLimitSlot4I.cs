using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021544", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1800SarBackOffLimitSlot4
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}