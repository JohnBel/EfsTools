using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022934", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc1TxExpLpmHdet
    {
        public byte LpmEnable { get; set; }


        public ushort LpmOffset { get; set; }


        public ushort LpmSpan { get; set; }


        public ushort LpmThreshold { get; set; }


        public ushort LpmTxagcStart { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] LpmHdetVsAgcTable
        {
            get;
        }
    }
}