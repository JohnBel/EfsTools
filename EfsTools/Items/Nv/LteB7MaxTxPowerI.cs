using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6553)]
    [Attributes(9)]
    public sealed class LteB7MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}