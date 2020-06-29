using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6473)]
    [Attributes(9)]
    public sealed class Gsm1800LinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}