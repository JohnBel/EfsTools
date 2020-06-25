using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(807)]
    [Attributes(9)]
    public sealed class GsmVbattLoPaComp
    {
        public byte Value { get; set; }
    }
}