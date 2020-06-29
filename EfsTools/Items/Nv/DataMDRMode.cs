using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(297)]
    [Attributes(9)]
    public sealed class DataMdrMode
    {
        public byte Value { get; set; }
    }
}