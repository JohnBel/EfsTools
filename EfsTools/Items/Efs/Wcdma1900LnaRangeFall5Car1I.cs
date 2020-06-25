using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020615", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1900LnaRangeFall5Car1
    {
        public short Value { get; set; }
    }
}