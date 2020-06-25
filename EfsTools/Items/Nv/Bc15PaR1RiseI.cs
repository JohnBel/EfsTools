using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4279)]
    [Attributes(9)]
    public sealed class Bc15PaR1Rise
    {
        public byte Value { get; set; }
    }
}