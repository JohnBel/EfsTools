using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3064)]
    [Attributes(9)]
    public sealed class GsmAntTimingRelToPaEnStart
    {
        public short Value { get; set; }
    }
}