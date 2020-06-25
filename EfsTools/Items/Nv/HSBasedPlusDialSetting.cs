using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4960)]
    [Attributes(9)]
    public sealed class HSBasedPlusDialSetting
    {
        public byte Value { get; set; }
    }
}