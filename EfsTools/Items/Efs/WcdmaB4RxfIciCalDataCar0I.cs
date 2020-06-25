using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023807", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB4RxfIciCalDataCar0
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
        public uint[] Value { get; set; }
    }
}