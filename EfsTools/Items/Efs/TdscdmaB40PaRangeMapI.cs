using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022707", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB40PaRangeMap
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public sbyte[] Value { get; set; }
    }
}