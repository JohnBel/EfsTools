using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025423", true, 0xE1FF)]
    [Attributes(9)]
    public class TdscdmaB34SarBackoffLimit
    {
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] SarBackOffLimitSlot1 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] SarBackOffLimitSlot2 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] SarBackOffLimitSlot3 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] SarBackOffLimitSlot4 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] SarBackOffLimitSlot5 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] SarBackOffLimitSlot6 { get; set; }
        
    }
}
