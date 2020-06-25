using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6381)]
    [Attributes(9)]
    public sealed class Gsm1800LinearPaR3VbattHiComp
    {
        public short Value { get; set; }
    }
}