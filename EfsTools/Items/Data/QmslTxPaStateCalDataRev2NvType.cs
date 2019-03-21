using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxPaStateCalDataRev2NvType
    {
        [ElementsCount(2)]
        [ElementType("tx_freq_offset_table_type")]
        [Description("")]
        public TxFreqOffsetTableType[] TxFreqOffsets { get; set; }
        
        [ElementsCount(4)]
        [ElementType("tx_linearizer_index_rev2_type")]
        [Description("")]
        public TxLinearizerIndexRev2Type[] TxLinearizerIndex { get; set; }
        
    }
}
