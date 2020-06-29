using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3397)]
    [Attributes(9)]
    public sealed class Gsm850PrechargeDur
    {
        public ushort Value { get; set; }
    }
}