using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3386)]
    [Attributes(9)]
    public sealed class Bc0HdrG0ImFall
    {
        public sbyte Value { get; set; }
    }
}