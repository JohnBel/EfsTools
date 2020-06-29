using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2432)]
    [Attributes(9)]
    public sealed class DcsVhTmPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}