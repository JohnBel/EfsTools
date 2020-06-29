using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2396)]
    [Attributes(9)]
    public sealed class DcsVlTmPrui14
    {
        [FieldCount(30)]
        public byte[] Value { get; set; }
    }
}