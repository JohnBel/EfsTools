using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6658)]
    [Attributes(9)]
    public sealed class LteB40MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}