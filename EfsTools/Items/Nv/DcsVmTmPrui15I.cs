using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2413)]
    [Attributes(9)]
    public sealed class DcsVmTmPrui15
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}