using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2326)]
    [Attributes(9)]
    public sealed class DcsEnableTxFreqCompVsPcl
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}