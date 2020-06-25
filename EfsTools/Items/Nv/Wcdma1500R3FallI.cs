using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6976)]
    [Attributes(9)]
    public sealed class Wcdma1500R3Fall
    {
        public ushort Value { get; set; }
    }
}