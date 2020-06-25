using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6234)]
    [Attributes(9)]
    public sealed class Bc15SubclassMask
    {
        public uint Value { get; set; }
    }
}