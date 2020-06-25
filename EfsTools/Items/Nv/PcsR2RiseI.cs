using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(339)]
    [Attributes(9)]
    public sealed class PcsR2Rise
    {
        public byte Value { get; set; }
    }
}