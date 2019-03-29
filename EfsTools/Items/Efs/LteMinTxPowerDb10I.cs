using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024738", true, 0xE1FF)]
    [Attributes(9)]
    public class LteMinTxPowerDb10
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Enable { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }
        
    }
}
