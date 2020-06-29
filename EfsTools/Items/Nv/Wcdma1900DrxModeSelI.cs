using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4195)]
    [Attributes(9)]
    public sealed class Wcdma1900DrxModeSel
    {
        [FieldCount(3)]
        public byte[] Value { get; set; }
    }
}