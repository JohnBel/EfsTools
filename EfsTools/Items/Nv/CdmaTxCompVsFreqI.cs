using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(130)]
    [Attributes(9)]
    public sealed class CdmaTxCompVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}