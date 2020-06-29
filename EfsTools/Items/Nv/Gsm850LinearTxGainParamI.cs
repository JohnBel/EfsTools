using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6472)]
    [Attributes(9)]
    public sealed class Gsm850LinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}