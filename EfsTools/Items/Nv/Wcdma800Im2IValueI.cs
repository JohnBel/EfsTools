using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1827)]
    [Attributes(9)]
    public sealed class Wcdma800Im2IValue
    {
        public byte Value { get; set; }
    }
}