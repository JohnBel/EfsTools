using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3505)]
    [Attributes(9)]
    public sealed class Gsm1900RxGainRange5FreqComp
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}