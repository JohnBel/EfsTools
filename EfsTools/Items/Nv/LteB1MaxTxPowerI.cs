using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6710)]
    [Attributes(9)]
    public sealed class LteB1MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}