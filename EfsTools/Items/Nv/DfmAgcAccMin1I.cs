using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(610)]
    [Attributes(9)]
    public sealed class DfmAgcAccMin1
    {
        public byte Value { get; set; }
    }
}