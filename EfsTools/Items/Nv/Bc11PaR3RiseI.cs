using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3868)]
    [Attributes(9)]
    public sealed class Bc11PaR3Rise
    {
        public byte Value { get; set; }
    }
}