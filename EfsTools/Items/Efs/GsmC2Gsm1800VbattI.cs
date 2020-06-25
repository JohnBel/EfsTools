using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025026", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1800Vbatt
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }
}