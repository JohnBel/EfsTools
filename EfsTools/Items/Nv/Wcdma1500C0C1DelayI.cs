using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7015)]
    [Attributes(9)]
    public sealed class Wcdma1500C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}