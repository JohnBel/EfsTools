using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020483", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaTxCompVsFreq3Mtd
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}