using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4200)]
    [Attributes(9)]
    public sealed class GpsDrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}