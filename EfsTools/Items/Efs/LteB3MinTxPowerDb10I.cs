using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024934", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB3MinTxPowerDb10
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Enable { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Value { get; set; }
        
    }
}
