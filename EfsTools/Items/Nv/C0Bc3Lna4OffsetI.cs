using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1579)]
    [Attributes(9)]
    public sealed class C0Bc3Lna4Offset
    {
        public short Value { get; set; }
    }
}