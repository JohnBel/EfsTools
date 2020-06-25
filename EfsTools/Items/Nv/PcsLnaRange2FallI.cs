using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(388)]
    [Attributes(9)]
    public sealed class PcsLnaRange2Fall
    {
        public sbyte Value { get; set; }
    }
}