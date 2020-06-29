using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020832", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB5C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}