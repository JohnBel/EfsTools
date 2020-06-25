using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1098)]
    [Attributes(9)]
    public sealed class Gsm1900PaStartTimeOffset
    {
        public sbyte Value { get; set; }
    }
}