using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2776)]
    [Attributes(9)]
    public sealed class Gsm850OpllBwVal
    {
        public byte Value { get; set; }
    }
}