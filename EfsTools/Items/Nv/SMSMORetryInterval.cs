using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3533)]
    [Attributes(9)]
    public sealed class SmsMoRetryInterval
    {
        public byte Value { get; set; }
    }
}