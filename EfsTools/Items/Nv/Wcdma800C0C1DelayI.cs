using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4939)]
    [Attributes(9)]
    public sealed class Wcdma800C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}