using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020614", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1900LnaRangeRise5Car1
    {
        public short Value { get; set; }
    }
}