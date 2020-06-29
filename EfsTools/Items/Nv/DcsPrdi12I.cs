using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2134)]
    [Attributes(9)]
    public sealed class DcsPrdi12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}