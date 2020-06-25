using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3540)]
    [Attributes(9)]
    public sealed class Bc14Gps1RfDelay
    {
        public ushort Value { get; set; }
    }
}