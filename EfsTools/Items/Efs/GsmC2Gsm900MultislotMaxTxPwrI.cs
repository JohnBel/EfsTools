using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025065", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm900MultislotMaxTxPwr
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public short[] GsmMultislotTxPwrGmsk { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public short[] GsmMultislotTxPwr8psk { get; set; }
    }
}