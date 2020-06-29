using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2895)]
    [Attributes(9)]
    public sealed class Wcdma1800HdetOff
    {
        public byte Value { get; set; }
    }
}