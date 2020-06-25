using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3630)]
    [Attributes(9)]
    public sealed class EdaFeatureSupport
    {
        public byte Value { get; set; }
    }
}