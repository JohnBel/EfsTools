using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4938)]
    [Attributes(9)]
    public sealed class Wcdma900C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}