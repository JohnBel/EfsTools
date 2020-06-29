using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(687)]
    [Attributes(9)]
    public sealed class CdmaIm2IValue
    {
        public byte Value { get; set; }
    }
}