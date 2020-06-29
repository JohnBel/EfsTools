using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4074)]
    [Attributes(9)]
    public sealed class WcdmaBc4PrachR3FallOffset
    {
        public short Value { get; set; }
    }
}