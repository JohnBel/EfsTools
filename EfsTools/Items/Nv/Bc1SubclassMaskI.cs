using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6220)]
    [Attributes(9)]
    public sealed class Bc1SubclassMask
    {
        public uint Value { get; set; }
    }
}