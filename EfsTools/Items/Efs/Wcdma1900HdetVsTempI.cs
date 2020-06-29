using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024591", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1900HdetVsTemp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}