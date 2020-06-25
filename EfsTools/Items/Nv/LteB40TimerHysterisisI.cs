using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6666)]
    [Attributes(9)]
    public sealed class LteB40TimerHysterisis
    {
        public short Value { get; set; }
    }
}