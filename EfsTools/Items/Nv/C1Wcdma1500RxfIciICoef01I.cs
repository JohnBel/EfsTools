using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7100)]
    [Attributes(9)]
    public sealed class C1Wcdma1500RxfIciICoef01
    {
        public uint Value { get; set; }
    }
}