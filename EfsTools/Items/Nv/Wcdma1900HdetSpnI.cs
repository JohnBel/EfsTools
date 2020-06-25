using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1188)]
    [Attributes(9)]
    public sealed class Wcdma1900HdetSpn
    {
        public byte Value { get; set; }
    }
}