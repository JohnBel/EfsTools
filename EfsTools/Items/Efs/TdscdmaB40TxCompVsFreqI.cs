using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022727", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB40TxCompVsFreq
    {
        [FieldCount(64)]
        public sbyte[] Value { get; set; }
    }
}