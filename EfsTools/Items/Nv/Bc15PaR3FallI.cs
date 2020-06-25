using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4284)]
    [Attributes(9)]
    public sealed class Bc15PaR3Fall
    {
        public byte Value { get; set; }
    }
}