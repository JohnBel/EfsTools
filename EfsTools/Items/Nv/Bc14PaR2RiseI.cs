using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3549)]
    [Attributes(9)]
    public sealed class Bc14PaR2Rise
    {
        public byte Value { get; set; }
    }
}