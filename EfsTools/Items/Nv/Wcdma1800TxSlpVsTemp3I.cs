using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2888)]
    [Attributes(9)]
    public sealed class Wcdma1800TxSlpVsTemp3
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}