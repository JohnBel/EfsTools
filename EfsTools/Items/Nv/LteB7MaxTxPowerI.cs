using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6553)]
    [Attributes(9)]
    public sealed class LteB7MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}