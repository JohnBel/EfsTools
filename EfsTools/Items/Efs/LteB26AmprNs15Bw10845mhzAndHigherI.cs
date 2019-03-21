using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024820", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB26AmprNs15Bw10845mhzAndHigherI
    {
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
        
    }
}
