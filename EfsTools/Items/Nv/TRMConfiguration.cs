using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3446)]
    [Attributes(9)]
    public sealed class TrmConfiguration
    {
        public ushort Config { get; set; }


        public uint Mask { get; set; }
    }
}