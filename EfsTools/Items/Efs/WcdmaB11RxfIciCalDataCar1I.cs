using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022581", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB11RxfIciCalDataCar1
    {
        [FieldCount(17)]
        public uint[] Value { get; set; }
    }
}