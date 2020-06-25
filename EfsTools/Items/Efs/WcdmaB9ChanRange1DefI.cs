using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022447", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB9ChanRange1Def
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] Value { get; set; }
    }
}