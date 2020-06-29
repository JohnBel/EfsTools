using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(136)]
    [Attributes(9)]
    public sealed class CdmaTxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}