using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022609", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB34LnaRangeRiseFallWbModeIdle
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] Value { get; set; }
    }
}