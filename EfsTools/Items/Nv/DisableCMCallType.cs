using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5280)]
    [Attributes(9)]
    public sealed class DisableCmCallType
    {
        public ulong Value { get; set; }
    }
}