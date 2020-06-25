using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2075)]
    [Attributes(9)]
    public sealed class Wcdma800PrachR2RiseOffset
    {
        public short Value { get; set; }
    }
}