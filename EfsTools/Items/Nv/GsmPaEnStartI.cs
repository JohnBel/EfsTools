using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3063)]
    [Attributes(9)]
    public sealed class GsmPaEnStart
    {
        public short Value { get; set; }
    }
}