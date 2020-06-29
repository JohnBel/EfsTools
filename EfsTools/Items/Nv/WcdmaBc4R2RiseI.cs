using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4059)]
    [Attributes(9)]
    public sealed class WcdmaBc4R2Rise
    {
        public ushort Value { get; set; }
    }
}