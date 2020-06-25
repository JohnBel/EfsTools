using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3716)]
    [Attributes(9)]
    public sealed class Wcdma900R3Rise
    {
        public ushort Value { get; set; }
    }
}