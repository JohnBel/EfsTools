using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024585", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaBc4MtplVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}