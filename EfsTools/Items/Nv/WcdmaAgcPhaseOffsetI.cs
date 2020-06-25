using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(528)]
    [Attributes(9)]
    public sealed class WcdmaAgcPhaseOffset
    {
        public byte Value { get; set; }
    }
}