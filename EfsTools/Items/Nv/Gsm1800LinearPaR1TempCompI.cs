using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6351)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR1TempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}