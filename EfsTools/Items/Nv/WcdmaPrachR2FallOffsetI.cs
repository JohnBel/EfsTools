using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2026)]
    [Attributes(9)]
    public sealed class WcdmaPrachR2FallOffset
    {
        public short Value { get; set; }
    }
}