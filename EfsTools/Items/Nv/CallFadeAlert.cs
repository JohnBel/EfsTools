using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(70)]
    [Attributes(9)]
    public sealed class CallFadeAlert
    {
        public byte Value { get; set; }
    }
}