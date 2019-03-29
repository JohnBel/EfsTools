using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024825", true, 0xE1FF)]
    [Attributes(9)]
    public class LtePartialB40Control
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PartialBandEnabled { get; set; }
        
    }
}
