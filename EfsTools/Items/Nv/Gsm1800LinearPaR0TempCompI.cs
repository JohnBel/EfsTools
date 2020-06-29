using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6350)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR0TempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}