using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2126)]
    [Attributes(9)]
    public sealed class DcsPrdi04
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}