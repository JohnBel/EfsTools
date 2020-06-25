using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(343)]
    [Attributes(9)]
    public sealed class PcsPaRangeStepCal
    {
        public byte Value { get; set; }
    }
}