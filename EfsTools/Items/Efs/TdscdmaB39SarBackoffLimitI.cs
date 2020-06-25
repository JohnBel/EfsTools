using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025424", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB39SarBackoffLimit
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] SarBackOffLimitSlot1 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] SarBackOffLimitSlot2 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] SarBackOffLimitSlot3 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] SarBackOffLimitSlot4 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] SarBackOffLimitSlot5 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] SarBackOffLimitSlot6 { get; set; }
    }
}