using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3682)]
    [Attributes(9)]
    public sealed class Wcdma900TxCompVsFreq0
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}