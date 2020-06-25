using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3588)]
    [Attributes(9)]
    public sealed class C0Bc14ImLevel4
    {
        public byte Value { get; set; }
    }
}