using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(75)]
    [Attributes(9)]
    public sealed class AutoRedialSetting
    {
        public byte Enable { get; set; }


        public byte Rings { get; set; }
    }
}