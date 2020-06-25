using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4128)]
    [Attributes(9)]
    public sealed class Gsm850GmskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}