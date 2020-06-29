using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2415)]
    [Attributes(9)]
    public sealed class DcsVmTmPrui13
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}