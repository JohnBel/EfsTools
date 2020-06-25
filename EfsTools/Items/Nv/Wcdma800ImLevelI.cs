using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1836)]
    [Attributes(9)]
    public sealed class Wcdma800ImLevel
    {
        public short Value { get; set; }
    }
}