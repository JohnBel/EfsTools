using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5477)]
    [Attributes(9)]
    public sealed class GsmLinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}