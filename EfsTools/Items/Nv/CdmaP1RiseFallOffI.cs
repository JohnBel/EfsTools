using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(901)]
    [Attributes(9)]
    public sealed class CdmaP1RiseFallOff
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}