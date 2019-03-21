using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxPaStateCalDataNvType
    {
        [ElementsCount(1)]
        [ElementType("tx_freq_offset_table_type")]
        [Description("")]
        public TxFreqOffsetTableType TxFreqOffsets { get; set; }
        
        [ElementsCount(3)]
        [ElementType("tx_linearizer_index_type")]
        [Description("")]
        public TxLinearizerIndexType[] TxLinearizerIndex { get; set; }
        
    }
}
