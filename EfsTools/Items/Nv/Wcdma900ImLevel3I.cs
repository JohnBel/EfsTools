using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3658)]
    [Attributes(9)]
    public sealed class Wcdma900ImLevel3
    {
        public short Value { get; set; }
    }
}