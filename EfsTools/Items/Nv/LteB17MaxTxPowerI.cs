using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6606)]
    [Attributes(9)]
    public sealed class LteB17MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}