using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(190)]
    [Attributes(9)]
    public sealed class FmLnaCtl
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}