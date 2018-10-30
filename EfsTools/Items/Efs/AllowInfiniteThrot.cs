using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/allow_infinite_throt", true, 0xE1FF)]
    [Attributes(9)]
    public class AllowInfiniteThrot
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}