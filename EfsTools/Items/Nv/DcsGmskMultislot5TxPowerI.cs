using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4136)]
    [Attributes(9)]
    public sealed class DcsGmskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}