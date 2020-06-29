using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4072)]
    [Attributes(9)]
    public sealed class WcdmaBc4PrachR2FallOffset
    {
        public short Value { get; set; }
    }
}