using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5478)]
    [Attributes(9)]
    public sealed class EdgeLinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}