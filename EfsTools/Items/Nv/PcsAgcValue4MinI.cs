using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(718)]
    [Attributes(9)]
    public sealed class PcsAgcValue4Min
    {
        public sbyte Value { get; set; }
    }
}