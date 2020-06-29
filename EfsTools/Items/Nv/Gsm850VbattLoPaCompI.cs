using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1139)]
    [Attributes(9)]
    public sealed class Gsm850VbattLoPaComp
    {
        public byte Value { get; set; }
    }
}