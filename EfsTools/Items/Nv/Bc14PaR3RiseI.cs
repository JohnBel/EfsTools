using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3551)]
    [Attributes(9)]
    public sealed class Bc14PaR3Rise
    {
        public byte Value { get; set; }
    }
}