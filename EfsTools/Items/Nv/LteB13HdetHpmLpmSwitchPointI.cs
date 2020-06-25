using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7227)]
    [Attributes(9)]
    public sealed class LteB13HdetHpmLpmSwitchPoint
    {
        public ushort Value { get; set; }
    }
}