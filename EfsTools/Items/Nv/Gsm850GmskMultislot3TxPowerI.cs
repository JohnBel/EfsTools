using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4126)]
    [Attributes(9)]
    public sealed class Gsm850GmskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}