using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3071)]
    [Attributes(9)]
    public sealed class GsmAntTimingRelToPaEnStop
    {
        public short Value { get; set; }
    }
}