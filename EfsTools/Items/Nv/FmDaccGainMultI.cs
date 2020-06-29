using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(685)]
    [Attributes(9)]
    public sealed class FmDaccGainMult
    {
        public byte Value { get; set; }
    }
}