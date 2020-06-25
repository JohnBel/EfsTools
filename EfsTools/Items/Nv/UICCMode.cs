using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6862)]
    [Attributes(9)]
    public sealed class UiccMode
    {
        public byte Value { get; set; }
    }
}