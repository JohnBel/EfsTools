using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3067)]
    [Attributes(9)]
    public sealed class Gsm850PaEnStart
    {
        public short Value { get; set; }
    }
}