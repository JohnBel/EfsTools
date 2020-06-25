using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024858", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33AgcTxOnRiseFallDelay
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] AgcTxOnRiseFallDelayType { get; set; }
    }
}