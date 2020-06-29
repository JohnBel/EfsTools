using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6502)]
    [Attributes(9)]
    public sealed class LteB13MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}