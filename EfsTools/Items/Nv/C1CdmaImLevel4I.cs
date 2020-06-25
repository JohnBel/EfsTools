using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1052)]
    [Attributes(9)]
    public sealed class C1CdmaImLevel4
    {
        public byte Value { get; set; }
    }
}