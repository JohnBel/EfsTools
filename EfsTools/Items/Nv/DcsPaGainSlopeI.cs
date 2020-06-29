using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(803)]
    [Attributes(9)]
    public sealed class DcsPaGainSlope
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}