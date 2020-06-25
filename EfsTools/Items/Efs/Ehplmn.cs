using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/nas/ehplmn", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Ehplmn
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 61)]
        public byte[] Value { get; set; }
    }
}