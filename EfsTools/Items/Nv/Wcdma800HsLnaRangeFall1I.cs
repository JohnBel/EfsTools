using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4776)]
    [Attributes(9)]
    public sealed class Wcdma800HsLnaRangeFall1
    {
        public short Value { get; set; }
    }
}