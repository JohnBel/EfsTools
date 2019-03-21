using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class TxLinearizerIndexRev2Type
    {
        [ElementsCount(16)]
        [ElementType("QMSL_Tx_Cal_Multi_Linearizer_Index_Node_Rev2_NV_Type")]
        [Description("")]
        public QmslTxCalMultiLinearizerIndexNodeRev2NvType[] NodeType { get; set; }
        
    }
}
