using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(807)]
    [Attributes(9)]
    public sealed class GsmVbattLoPaComp
    {
        public byte Value { get; set; }
    }
}