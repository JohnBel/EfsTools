using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6437)]
    [Attributes(9)]
    public sealed class Wcdma900RxfIciICoef45
    {
        public uint Value { get; set; }
    }
}