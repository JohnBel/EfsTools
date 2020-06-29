using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2416)]
    [Attributes(9)]
    public sealed class DcsVmTmPrdi15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}