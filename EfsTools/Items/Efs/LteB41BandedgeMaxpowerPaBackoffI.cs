using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025200", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB41BandedgeMaxpowerPaBackoffI
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Enable { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte LowerbandPaSwitchptBackoff { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte UpperbandPaSwitchptBackoff { get; set; }
        
    }
}
