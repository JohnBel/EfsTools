using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1832)]
    [Attributes(9)]
    public sealed class Wcdma800MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}