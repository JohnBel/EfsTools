using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(135)]
    [Attributes(9)]
    public sealed class CdmaTxLinVsVolt
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}