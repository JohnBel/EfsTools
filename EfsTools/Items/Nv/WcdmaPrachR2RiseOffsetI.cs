using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2025)]
    [Attributes(9)]
    public sealed class WcdmaPrachR2RiseOffset
    {
        public short Value { get; set; }
    }
}