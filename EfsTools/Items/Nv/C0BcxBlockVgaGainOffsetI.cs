using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4585)]
    [Attributes(9)]
    public sealed class C0BcxBlockVgaGainOffset
    {
        public short Value { get; set; }
    }
}