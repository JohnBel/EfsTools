using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022705", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB40TxLinVsTemp
    {
        [FieldCount(32)]
        public sbyte[] Value { get; set; }
    }
}