using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2731)]
    [Attributes(9)]
    public sealed class Wcdma1900HsR1Fall
    {
        public short Value { get; set; }
    }
}