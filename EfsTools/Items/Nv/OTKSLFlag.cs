using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(304)]
    [Attributes(13)]
    public sealed class OTKSLFlag
    {
        public byte Value { get; set; }
    }
}