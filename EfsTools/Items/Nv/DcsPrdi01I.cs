using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2123)]
    [Attributes(9)]
    public sealed class DcsPrdi01
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}