using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(351)]
    [Attributes(9)]
    public sealed class PcsAdjFactor
    {
        public byte Value { get; set; }
    }
}