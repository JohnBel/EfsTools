using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2114)]
    [Attributes(9)]
    public sealed class DcsPrui05
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}