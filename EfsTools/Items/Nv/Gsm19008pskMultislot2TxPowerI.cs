using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4153)]
    [Attributes(9)]
    public sealed class Gsm19008pskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}