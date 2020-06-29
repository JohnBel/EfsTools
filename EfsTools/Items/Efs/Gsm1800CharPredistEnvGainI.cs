using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024196", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1800CharPredistEnvGain
    {
        [FieldCount(64)]
        public byte[] Value { get; set; }
    }
}