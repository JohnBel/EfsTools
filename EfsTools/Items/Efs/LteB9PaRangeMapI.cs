using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023497", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB9PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}