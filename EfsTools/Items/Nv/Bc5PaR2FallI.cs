using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1404)]
    [Attributes(9)]
    public sealed class Bc5PaR2Fall
    {
        public byte Value { get; set; }
    }
}