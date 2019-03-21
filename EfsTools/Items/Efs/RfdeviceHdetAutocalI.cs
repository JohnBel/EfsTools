using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023764", true, 0xE1FF)]
    [Attributes(9)]
    public class RfdeviceHdetAutocalI
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte HdetAutocalDevice0 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte HdetAutocalDevice1 { get; set; }
        
    }
}
