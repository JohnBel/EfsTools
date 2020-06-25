using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5746)]
    [Attributes(9)]
    public sealed class Bc8HdetOffV2
    {
        public ushort Value { get; set; }
    }
}