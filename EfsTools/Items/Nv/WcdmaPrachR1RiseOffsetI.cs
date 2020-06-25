using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1908)]
    [Attributes(9)]
    public sealed class WcdmaPrachR1RiseOffset
    {
        public short Value { get; set; }
    }
}