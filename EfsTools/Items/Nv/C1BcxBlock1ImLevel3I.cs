using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6130)]
    [Attributes(9)]
    public sealed class C1BcxBlock1ImLevel3
    {
        public byte Value { get; set; }
    }
}