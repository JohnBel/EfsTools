using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2027)]
    [Attributes(9)]
    public sealed class WcdmaPrachR3RiseOffset
    {
        public short Value { get; set; }
    }
}