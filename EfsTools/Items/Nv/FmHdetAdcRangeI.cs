using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(311)]
    [Attributes(9)]
    public sealed class FmHdetAdcRange
    {
        [FieldCount(6)]
        public byte[] Value { get; set; }
    }
}