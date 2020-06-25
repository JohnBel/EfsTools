using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7098)]
    [Attributes(9)]
    public sealed class C1Wcdma1500RxfMisCompACoeff
    {
        public short Value { get; set; }
    }
}