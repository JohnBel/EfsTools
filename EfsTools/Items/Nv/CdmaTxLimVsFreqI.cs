using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(138)]
    [Attributes(9)]
    public sealed class CdmaTxLimVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}