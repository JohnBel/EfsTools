using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1624)]
    [Attributes(9)]
    public sealed class Bc1Gps1RfDelay
    {
        public short Value { get; set; }
    }
}