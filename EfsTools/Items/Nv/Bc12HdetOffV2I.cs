using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5750)]
    [Attributes(9)]
    public sealed class Bc12HdetOffV2
    {
        public ushort Value { get; set; }
    }
}