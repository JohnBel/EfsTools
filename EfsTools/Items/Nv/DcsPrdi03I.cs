using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2125)]
    [Attributes(9)]
    public sealed class DcsPrdi03
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}