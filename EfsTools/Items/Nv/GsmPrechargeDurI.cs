using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(815)]
    [Attributes(9)]
    public sealed class GsmPrechargeDur
    {
        public ushort Value { get; set; }
    }
}