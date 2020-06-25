using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4412)]
    [Attributes(9)]
    public sealed class Wcdma800LnaRangeFall4
    {
        public short Value { get; set; }
    }
}