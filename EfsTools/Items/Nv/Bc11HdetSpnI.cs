using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3871)]
    [Attributes(9)]
    public sealed class Bc11HdetSpn
    {
        public byte Value { get; set; }
    }
}