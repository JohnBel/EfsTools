using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3388)]
    [Attributes(9)]
    public sealed class Bc0HdrG0ImLevel
    {
        public sbyte Value { get; set; }
    }
}