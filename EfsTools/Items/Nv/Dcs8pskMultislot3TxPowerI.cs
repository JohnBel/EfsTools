using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4150)]
    [Attributes(9)]
    public sealed class Dcs8pskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}