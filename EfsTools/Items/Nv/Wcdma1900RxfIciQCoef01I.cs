using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5954)]
    [Attributes(9)]
    public sealed class Wcdma1900RxfIciQCoef01
    {
        public uint Value { get; set; }
    }
}