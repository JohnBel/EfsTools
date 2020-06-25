using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4147)]
    [Attributes(9)]
    public sealed class Gsm8pskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}