using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(199)]
    [Attributes(9)]
    public sealed class CdmaRxLinVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}