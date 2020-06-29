using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(202)]
    [Attributes(9)]
    public sealed class CdmaRxSlpVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}