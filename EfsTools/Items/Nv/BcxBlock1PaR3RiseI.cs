using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6070)]
    [Attributes(9)]
    public sealed class BcxBlock1PaR3Rise
    {
        public byte Value { get; set; }
    }
}