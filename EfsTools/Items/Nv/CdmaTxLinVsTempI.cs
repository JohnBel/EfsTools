using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(134)]
    [Attributes(9)]
    public sealed class CdmaTxLinVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}