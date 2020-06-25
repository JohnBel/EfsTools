using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3819)]
    [Attributes(9)]
    public sealed class C1Wcdma800VgaGainOffset
    {
        public short Value { get; set; }
    }
}