using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5974)]
    [Attributes(9)]
    public sealed class C1Wcdma1900RxfIciQCoef89
    {
        public uint Value { get; set; }
    }
}