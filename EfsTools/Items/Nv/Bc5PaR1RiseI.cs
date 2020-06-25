using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1401)]
    [Attributes(9)]
    public sealed class Bc5PaR1Rise
    {
        public byte Value { get; set; }
    }
}