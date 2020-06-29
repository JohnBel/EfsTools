using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2321)]
    [Attributes(9)]
    public sealed class Gsm1900C0TxFreqComp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}