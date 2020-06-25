using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1244)]
    [Attributes(9)]
    public sealed class Bc6Lna3Offset
    {
        public short Value { get; set; }
    }
}