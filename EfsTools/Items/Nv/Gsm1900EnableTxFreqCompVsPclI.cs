using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2327)]
    [Attributes(9)]
    public sealed class Gsm1900EnableTxFreqCompVsPcl
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}