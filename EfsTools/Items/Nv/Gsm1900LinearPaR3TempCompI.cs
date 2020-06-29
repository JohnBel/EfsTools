using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6357)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR3TempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}