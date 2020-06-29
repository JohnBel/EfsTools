using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(133)]
    [Attributes(9)]
    public sealed class CdmaTxLinMasterSlp
    {
        [FieldCount(37)]
        public byte[] Value { get; set; }
    }
}