using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1247)]
    [Attributes(9)]
    public sealed class Bc6Lna4Fall
    {
        public sbyte Value { get; set; }
    }
}