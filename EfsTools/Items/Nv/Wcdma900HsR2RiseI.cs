using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3748)]
    [Attributes(9)]
    public sealed class Wcdma900HsR2Rise
    {
        public short Value { get; set; }
    }
}