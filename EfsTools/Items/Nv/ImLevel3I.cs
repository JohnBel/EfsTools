using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(585)]
    [Attributes(9)]
    public sealed class ImLevel3
    {
        public sbyte Value { get; set; }
    }
}