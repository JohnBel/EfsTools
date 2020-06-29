using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6474)]
    [Attributes(9)]
    public sealed class Gsm1900LinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}