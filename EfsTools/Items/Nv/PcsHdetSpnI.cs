using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(336)]
    [Attributes(9)]
    public sealed class PcsHdetSpn
    {
        public byte Value { get; set; }
    }
}