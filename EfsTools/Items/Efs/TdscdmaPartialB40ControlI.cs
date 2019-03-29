using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024826", true, 0xE1FF)]
    [Attributes(9)]
    public class TdscdmaPartialB40Control
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PartialBandEnabled { get; set; }
        
    }
}
