using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5745)]
    [Attributes(9)]
    public sealed class Bc7HdetOffV2
    {
        public ushort Value { get; set; }
    }
}