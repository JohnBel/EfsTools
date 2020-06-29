using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024197", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1900CharPredistEnvGain
    {
        [FieldCount(64)]
        public byte[] Value { get; set; }
    }
}