using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2109)]
    [Attributes(9)]
    public sealed class DcsPrui00
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}