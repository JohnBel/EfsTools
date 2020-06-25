using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1544)]
    [Attributes(9)]
    public sealed class C1Bc4ImLevel4
    {
        public byte Value { get; set; }
    }
}