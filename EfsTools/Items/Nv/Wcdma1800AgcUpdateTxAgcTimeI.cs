using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2905)]
    [Attributes(9)]
    public sealed class Wcdma1800AgcUpdateTxAgcTime
    {
        public ushort Value { get; set; }
    }
}