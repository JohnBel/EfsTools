using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3669)]
    [Attributes(9)]
    public sealed class Wcdma900OutOfServiceThresh
    {
        public short Value { get; set; }
    }
}