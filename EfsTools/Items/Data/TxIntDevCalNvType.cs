using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class TxIntDevCalNvType
    {
        [ElementsCount(8)]
        [ElementType("uint64")]
        [Description("")]
        public ulong[] CdmaBcTxIntCal { get; set; }
        
        [ElementsCount(8)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] GsmBcTxIntCal { get; set; }
        
        [ElementsCount(8)]
        [ElementType("uint64")]
        [Description("")]
        public ulong[] WcdmaBcTxIntCal { get; set; }
        
        [ElementsCount(8)]
        [ElementType("uint64")]
        [Description("")]
        public ulong[] LteBcTxIntCal { get; set; }
        
        [ElementsCount(8)]
        [ElementType("uint64")]
        [Description("")]
        public ulong[] TdscdmaBcTxIntCal { get; set; }
        
    }
}
