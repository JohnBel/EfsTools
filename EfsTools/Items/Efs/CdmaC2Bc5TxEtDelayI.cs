using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025518", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc5TxEtDelay
    {
        public int Delay { get; set; }
    }
}