using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1061)]
    [Attributes(9)]
    public sealed class Gsm1900RxGainRange4FreqComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}