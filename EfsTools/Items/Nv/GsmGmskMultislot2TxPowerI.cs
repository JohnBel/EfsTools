using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4129)]
    [Attributes(9)]
    public sealed class GsmGmskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}