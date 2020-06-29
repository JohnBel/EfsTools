using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3690)]
    [Attributes(9)]
    public sealed class Wcdma900TxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}