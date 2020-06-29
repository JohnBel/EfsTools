using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6356)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR2TempComp
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}