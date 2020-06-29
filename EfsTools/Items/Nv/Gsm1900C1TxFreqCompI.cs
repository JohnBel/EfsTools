using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2324)]
    [Attributes(9)]
    public sealed class Gsm1900C1TxFreqComp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}