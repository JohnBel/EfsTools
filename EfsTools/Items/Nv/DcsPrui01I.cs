using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2110)]
    [Attributes(9)]
    public sealed class DcsPrui01
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}