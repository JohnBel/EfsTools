using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2121)]
    [Attributes(9)]
    public sealed class DcsPrui12
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}