using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022606", true, 0xE1FF)]
    [Attributes(9)]
    public class TdscdmaB34LnaRangeRiseFallNbModeAcqI
    {
        [ElementsCount(12)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
        
    }
}
