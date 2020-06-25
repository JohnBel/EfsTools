using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(986)]
    [Attributes(9)]
    public sealed class C1GpsDaccIaccum0
    {
        public byte Value { get; set; }
    }
}