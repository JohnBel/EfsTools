using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4458)]
    [Attributes(9)]
    public sealed class C1Wcdma1800NonbypassTimer
    {
        public byte Value { get; set; }
    }
}