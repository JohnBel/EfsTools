using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4143)]
    [Attributes(9)]
    public sealed class Gsm8508pskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}