using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4151)]
    [Attributes(9)]
    public sealed class Dcs8pskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}