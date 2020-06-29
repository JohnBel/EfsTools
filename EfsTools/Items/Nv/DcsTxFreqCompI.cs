using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(805)]
    [Attributes(9)]
    public sealed class DcsTxFreqComp
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}