using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(146)]
    [Attributes(9)]
    public sealed class FmAgcAdjVsFreq
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}