using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4060)]
    [Attributes(9)]
    public sealed class WcdmaBc4R2Fall
    {
        public ushort Value { get; set; }
    }
}