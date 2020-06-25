using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6605)]
    [Attributes(9)]
    public sealed class LteB17EncBtf
    {
        public short Value { get; set; }
    }
}