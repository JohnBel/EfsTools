using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(203)]
    [Attributes(9)]
    public sealed class CdmaTxSlpVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}