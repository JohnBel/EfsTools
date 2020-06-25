using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1408)]
    [Attributes(9)]
    public sealed class Bc5HdetSpn
    {
        public byte Value { get; set; }
    }
}