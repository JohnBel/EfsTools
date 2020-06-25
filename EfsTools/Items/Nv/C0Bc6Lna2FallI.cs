using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1366)]
    [Attributes(9)]
    public sealed class C0Bc6Lna2Fall
    {
        public sbyte Value { get; set; }
    }
}