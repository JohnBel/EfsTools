using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(595)]
    [Attributes(9)]
    public sealed class PcsLna3Offset
    {
        public short Value { get; set; }
    }
}