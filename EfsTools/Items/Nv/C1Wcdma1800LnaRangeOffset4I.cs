using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4451)]
    [Attributes(9)]
    public sealed class C1Wcdma1800LnaRangeOffset4
    {
        public short Value { get; set; }
    }
}