using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(881)]
    [Attributes(9)]
    public sealed class RrcCipheringEnabled
    {
        public byte Value { get; set; }
    }
}