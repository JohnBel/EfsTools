using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1402)]
    [Attributes(9)]
    public sealed class Bc5PaR1Fall
    {
        public byte Value { get; set; }
    }
}