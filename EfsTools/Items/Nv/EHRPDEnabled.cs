using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6248)]
    [Attributes(9)]
    public sealed class EhrpdEnabled
    {
        public byte Value { get; set; }
    }
}