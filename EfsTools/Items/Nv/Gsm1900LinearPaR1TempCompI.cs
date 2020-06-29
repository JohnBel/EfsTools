using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6355)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR1TempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}