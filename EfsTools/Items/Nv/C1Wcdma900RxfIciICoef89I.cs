using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6456)]
    [Attributes(9)]
    public sealed class C1Wcdma900RxfIciICoef89
    {
        public uint Value { get; set; }
    }
}