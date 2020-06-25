using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(734)]
    [Attributes(9)]
    public sealed class GsmTrkLoAdjPdmInitVal
    {
        public ushort Value { get; set; }
    }
}