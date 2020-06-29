using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2115)]
    [Attributes(9)]
    public sealed class DcsPrui06
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}