using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022567", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB11LnaRangeOffset2Car1
    {
        public short Value { get; set; }
    }
}