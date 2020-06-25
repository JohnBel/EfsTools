using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5181)]
    [Attributes(9)]
    public sealed class Bc10HdetSpn
    {
        public byte Value { get; set; }
    }
}