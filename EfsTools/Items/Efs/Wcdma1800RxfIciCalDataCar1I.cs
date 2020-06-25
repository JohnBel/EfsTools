using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023782", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1800RxfIciCalDataCar1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
        public uint[] Value { get; set; }
    }
}