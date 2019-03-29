using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023918", true, 0xE1FF)]
    [Attributes(9)]
    public class Wcdma800TxMultiLinV2Data
    {
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Cal_Complete_Rev2_NV_Type")]
        [Description("")]
        public QmslTxCalCompleteRev2NvType Value { get; set; }
        
    }
}
