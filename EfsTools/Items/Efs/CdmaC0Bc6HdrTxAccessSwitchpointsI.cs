using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022829", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC0Bc6HdrTxAccessSwitchpointsI
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short G1G0Fall { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short G0G1Rise { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short G2G1Fall { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short G1G2Rise { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short G3G2Fall { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short G2G3Rise { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short FallTimeHyst { get; set; }
        
    }
}
