using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1094)]
    [Attributes(9)]
    public sealed class Gsm1900PaGainSlope
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}