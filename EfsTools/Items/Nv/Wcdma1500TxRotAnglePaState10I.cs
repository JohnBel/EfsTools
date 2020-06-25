using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6983)]
    [Attributes(9)]
    public sealed class Wcdma1500TxRotAnglePaState10
    {
        public ushort Value { get; set; }
    }
}