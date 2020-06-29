using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020645", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaBc4PaSmpsAptPdm1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}