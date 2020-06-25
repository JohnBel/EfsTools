using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4286)]
    [Attributes(9)]
    public sealed class Bc15HdetSpn
    {
        public byte Value { get; set; }
    }
}