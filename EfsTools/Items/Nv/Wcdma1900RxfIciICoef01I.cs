using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5946)]
    [Attributes(9)]
    public sealed class Wcdma1900RxfIciICoef01
    {
        public uint Value { get; set; }
    }
}