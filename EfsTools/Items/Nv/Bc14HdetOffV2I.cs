using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5752)]
    [Attributes(9)]
    public sealed class Bc14HdetOffV2
    {
        public ushort Value { get; set; }
    }
}