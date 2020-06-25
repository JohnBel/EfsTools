using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7047)]
    [Attributes(9)]
    public sealed class Wcdma1500HsR1Rise
    {
        public short Value { get; set; }
    }
}