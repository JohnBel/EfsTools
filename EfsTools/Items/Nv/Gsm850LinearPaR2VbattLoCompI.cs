using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6362)]
    [Attributes(9)]
    public sealed class Gsm850LinearPaR2VbattLoComp
    {
        public short Value { get; set; }
    }
}