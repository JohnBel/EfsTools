using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(129)]
    [Attributes(9)]
    public sealed class CdmaRxCompVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}