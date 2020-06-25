using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(970)]
    [Attributes(9)]
    public sealed class C0RxAgcVrefVal
    {
        public byte Value { get; set; }
    }
}