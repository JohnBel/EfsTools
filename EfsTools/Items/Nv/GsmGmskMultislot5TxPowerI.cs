using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4132)]
    [Attributes(9)]
    public sealed class GsmGmskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}