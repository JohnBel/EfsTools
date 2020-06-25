using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3831)]
    [Attributes(9)]
    public sealed class C1Wcdma800ImLevel2
    {
        public short Value { get; set; }
    }
}