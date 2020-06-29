using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(731)]
    [Attributes(9)]
    public sealed class DcsRxGainRange2FreqComp
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}