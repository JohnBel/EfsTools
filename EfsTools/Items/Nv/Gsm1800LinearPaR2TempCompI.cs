using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6352)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR2TempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}