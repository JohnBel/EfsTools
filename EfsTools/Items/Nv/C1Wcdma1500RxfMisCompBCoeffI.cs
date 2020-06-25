using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7099)]
    [Attributes(9)]
    public sealed class C1Wcdma1500RxfMisCompBCoeff
    {
        public short Value { get; set; }
    }
}