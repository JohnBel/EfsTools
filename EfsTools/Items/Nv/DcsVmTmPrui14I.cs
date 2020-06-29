using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2414)]
    [Attributes(9)]
    public sealed class DcsVmTmPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}