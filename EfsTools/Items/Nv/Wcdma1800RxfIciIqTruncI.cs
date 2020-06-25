using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6410)]
    [Attributes(9)]
    public sealed class Wcdma1800RxfIciIqTrunc
    {
        public byte Value { get; set; }
    }
}