using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1058)]
    [Attributes(9)]
    public sealed class Gsm1900RxGainRange1FreqComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}