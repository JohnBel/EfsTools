using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1643)]
    [Attributes(9)]
    public sealed class Bc1HdetSpn
    {
        public byte Value { get; set; }
    }
}