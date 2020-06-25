using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6208)]
    [Attributes(9)]
    public sealed class BcxBlockBandClass
    {
        public byte Value { get; set; }
    }
}