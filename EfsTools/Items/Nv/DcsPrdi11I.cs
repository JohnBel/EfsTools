using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2133)]
    [Attributes(9)]
    public sealed class DcsPrdi11
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}