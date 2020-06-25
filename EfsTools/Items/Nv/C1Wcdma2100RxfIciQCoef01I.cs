using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5936)]
    [Attributes(9)]
    public sealed class C1Wcdma2100RxfIciQCoef01
    {
        public uint Value { get; set; }
    }
}