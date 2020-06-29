using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020857", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB8EncBtf
    {
        public int Value { get; set; }
    }
}