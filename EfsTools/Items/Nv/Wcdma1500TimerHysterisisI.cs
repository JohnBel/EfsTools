using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7027)]
    [Attributes(9)]
    public sealed class Wcdma1500TimerHysterisis
    {
        public short Value { get; set; }
    }
}