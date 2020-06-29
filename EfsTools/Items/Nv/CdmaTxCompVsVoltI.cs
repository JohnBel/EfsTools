using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(131)]
    [Attributes(9)]
    public sealed class CdmaTxCompVsVolt
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}