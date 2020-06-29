using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020764", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB7PaSmpsOdrive
    {
        public ushort Value { get; set; }
    }
}