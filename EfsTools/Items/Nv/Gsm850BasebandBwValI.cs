using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2780)]
    [Attributes(9)]
    public sealed class Gsm850BasebandBwVal
    {
        public byte Value { get; set; }
    }
}