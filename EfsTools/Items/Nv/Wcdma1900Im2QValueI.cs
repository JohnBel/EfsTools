using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1157)]
    [Attributes(9)]
    public sealed class Wcdma1900Im2QValue
    {
        public byte Value { get; set; }
    }
}