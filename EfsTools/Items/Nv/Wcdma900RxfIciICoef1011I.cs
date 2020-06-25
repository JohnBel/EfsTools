using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6440)]
    [Attributes(9)]
    public sealed class Wcdma900RxfIciICoef1011
    {
        public uint Value { get; set; }
    }
}