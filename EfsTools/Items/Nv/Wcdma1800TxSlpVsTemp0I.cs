using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2885)]
    [Attributes(9)]
    public sealed class Wcdma1800TxSlpVsTemp0
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}