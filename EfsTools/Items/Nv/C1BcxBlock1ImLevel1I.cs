using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6128)]
    [Attributes(9)]
    public sealed class C1BcxBlock1ImLevel1
    {
        public byte Value { get; set; }
    }
}