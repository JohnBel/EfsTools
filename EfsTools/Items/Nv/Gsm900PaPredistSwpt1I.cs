using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5367)]
    [Attributes(9)]
    public sealed class Gsm900PaPredistSwpt1
    {
        public ushort Value { get; set; }
    }
}