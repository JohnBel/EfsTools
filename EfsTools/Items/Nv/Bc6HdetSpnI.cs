using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1219)]
    [Attributes(9)]
    public sealed class Bc6HdetSpn
    {
        public byte Value { get; set; }
    }
}