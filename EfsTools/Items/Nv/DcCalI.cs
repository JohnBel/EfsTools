using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5449)]
    [Attributes(9)]
    public sealed class DcCal
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}