using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1240)]
    [Attributes(9)]
    public sealed class Bc6EncBtf
    {
        public uint Value { get; set; }
    }
}