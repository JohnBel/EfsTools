using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(988)]
    [Attributes(9)]
    public sealed class C1PcsDaccIaccum1
    {
        public byte Value { get; set; }
    }
}