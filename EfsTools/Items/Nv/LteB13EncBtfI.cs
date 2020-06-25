using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6501)]
    [Attributes(9)]
    public sealed class LteB13EncBtf
    {
        public int Value { get; set; }
    }
}