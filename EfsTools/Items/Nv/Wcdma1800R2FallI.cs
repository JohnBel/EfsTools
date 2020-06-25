using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2920)]
    [Attributes(9)]
    public sealed class Wcdma1800R2Fall
    {
        public ushort Value { get; set; }
    }
}