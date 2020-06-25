using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2922)]
    [Attributes(9)]
    public sealed class Wcdma1800R3Fall
    {
        public ushort Value { get; set; }
    }
}