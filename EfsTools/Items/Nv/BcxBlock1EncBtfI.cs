using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6075)]
    [Attributes(9)]
    public sealed class BcxBlock1EncBtf
    {
        public uint Value { get; set; }
    }
}