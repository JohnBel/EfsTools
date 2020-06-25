using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1466)]
    [Attributes(9)]
    public sealed class C1Bc5ImLevel4
    {
        public byte Value { get; set; }
    }
}