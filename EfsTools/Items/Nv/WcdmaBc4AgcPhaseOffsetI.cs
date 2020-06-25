using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4024)]
    [Attributes(9)]
    public sealed class WcdmaBc4AgcPhaseOffset
    {
        public byte Value { get; set; }
    }
}