using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2738)]
    [Attributes(9)]
    public sealed class Wcdma800HsR2Rise
    {
        public short Value { get; set; }
    }
}