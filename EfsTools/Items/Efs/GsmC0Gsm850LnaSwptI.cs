using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024996", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm850LnaSwpt
    {
        public GsmRxLnaSwptType GsmRxLnaSwpt { get; set; }
    }
}