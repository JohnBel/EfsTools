using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1138)]
    [Attributes(9)]
    public sealed class Gsm850VbattHiPaComp
    {
        public byte Value { get; set; }
    }
}