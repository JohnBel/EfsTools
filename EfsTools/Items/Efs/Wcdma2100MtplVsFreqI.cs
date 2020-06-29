using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024583", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma2100MtplVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}