using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(137)]
    [Attributes(9)]
    public sealed class CdmaTxLimVsVolt
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}