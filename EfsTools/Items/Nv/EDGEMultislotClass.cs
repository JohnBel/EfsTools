using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2509)]
    [Attributes(9)]
    public sealed class EdgeMultislotClass
    {
        public byte Value { get; set; }
    }
}