using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2066)]
    [Attributes(9)]
    public sealed class Wcdma800R3Fall
    {
        public ushort Value { get; set; }
    }
}