using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6229)]
    [Attributes(9)]
    public sealed class Bc10SubclassMask
    {
        public uint Value { get; set; }
    }
}