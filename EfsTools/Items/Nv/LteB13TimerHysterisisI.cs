using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6510)]
    [Attributes(9)]
    public sealed class LteB13TimerHysterisis
    {
        public short Value { get; set; }
    }
}