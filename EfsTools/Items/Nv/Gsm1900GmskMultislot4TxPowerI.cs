using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4139)]
    [Attributes(9)]
    public sealed class Gsm1900GmskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}