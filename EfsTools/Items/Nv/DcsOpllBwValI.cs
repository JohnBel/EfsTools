using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2775)]
    [Attributes(9)]
    public sealed class DcsOpllBwVal
    {
        public byte Value { get; set; }
    }
}