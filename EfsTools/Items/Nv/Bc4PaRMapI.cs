using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4883)]
    [Attributes(9)]
    public sealed class Bc4PaRMap
    {
        public byte Value { get; set; }
    }
}