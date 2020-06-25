using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1160)]
    [Attributes(9)]
    public sealed class Wcdma1900RxAgcMin3
    {
        public short Value { get; set; }
    }
}