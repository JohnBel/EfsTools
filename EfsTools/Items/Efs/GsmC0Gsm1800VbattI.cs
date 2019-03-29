using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025022", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC0Gsm1800Vbatt
    {
        [ElementsCount(3)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] VbattLevels { get; set; }
        
        [ElementsCount(1)]
        [ElementType("GSM_TX_VBATT_COMP_DATA_TYPE")]
        [Description("")]
        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }
        
        [ElementsCount(1)]
        [ElementType("GSM_TX_VBATT_COMP_DATA_TYPE")]
        [Description("")]
        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
        
    }
}
