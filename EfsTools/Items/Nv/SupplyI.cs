using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5576)]
    [Attributes(9)]
    public sealed class Supply
    {
        public ushort Value { get; set; }
    }
}