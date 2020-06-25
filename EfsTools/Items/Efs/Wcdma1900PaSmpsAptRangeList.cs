using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020632", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1900PaSmpsAptRangeList
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Value { get; set; }
    }
}