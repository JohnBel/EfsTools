using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(429)]
    [Attributes(9)]
    public sealed class DataScRmEnabled
    {
        public byte Value { get; set; }
    }
}