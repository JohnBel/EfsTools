using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5371)]
    [Attributes(9)]
    public sealed class Gsm1900PaPredistSwpt1
    {
        public ushort Value { get; set; }
    }
}