using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3066)]
    [Attributes(9)]
    public sealed class DcsAntTimingRelToPaEnStart
    {
        public short Value { get; set; }
    }
}