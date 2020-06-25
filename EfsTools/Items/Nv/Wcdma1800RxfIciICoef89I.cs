using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6398)]
    [Attributes(9)]
    public sealed class Wcdma1800RxfIciICoef89
    {
        public uint Value { get; set; }
    }
}