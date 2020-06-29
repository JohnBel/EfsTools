using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(553)]
    [Attributes(9)]
    public sealed class GsmA5AlgorithmsSupported
    {
        public byte Value { get; set; }
    }
}