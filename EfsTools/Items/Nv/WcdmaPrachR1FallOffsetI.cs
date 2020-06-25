using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1910)]
    [Attributes(9)]
    public sealed class WcdmaPrachR1FallOffset
    {
        public short Value { get; set; }
    }
}