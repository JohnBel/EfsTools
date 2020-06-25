using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4272)]
    [Attributes(9)]
    public sealed class Bc15Gps1RfDelay
    {
        public ushort Value { get; set; }
    }
}