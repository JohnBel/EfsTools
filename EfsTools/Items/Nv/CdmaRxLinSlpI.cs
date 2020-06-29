using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(128)]
    [Attributes(9)]
    public sealed class CdmaRxLinSlp
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}