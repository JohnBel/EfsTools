using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3143)]
    [Attributes(9)]
    public sealed class DcsAmamArfcnF3
    {
        public ushort Value { get; set; }
    }
}