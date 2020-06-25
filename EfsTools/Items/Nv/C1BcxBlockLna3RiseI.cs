using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4619)]
    [Attributes(9)]
    public sealed class C1BcxBlockLna3Rise
    {
        public sbyte Value { get; set; }
    }
}