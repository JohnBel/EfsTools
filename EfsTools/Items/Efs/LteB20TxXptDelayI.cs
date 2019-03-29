using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025551", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB20TxXptDelay
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte NumActiveEntries { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] UpperBoundChannels { get; set; }
        
        [ElementsCount(16)]
        [ElementType("int32")]
        [Description("")]
        public int[] DelayLtebw5mhz { get; set; }
        
        [ElementsCount(16)]
        [ElementType("int32")]
        [Description("")]
        public int[] DelayLtebw10mhz { get; set; }
        
        [ElementsCount(16)]
        [ElementType("int32")]
        [Description("")]
        public int[] DelayLtebw20mhz { get; set; }
        
    }
}
