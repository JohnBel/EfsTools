using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxPaStateCalDataNvType
    {
        public TxFreqOffsetTableType TxFreqOffsets { get; set; }

        [FieldCount(3)]
        public TxLinearizerIndexType[] TxLinearizerIndex
        {
            get;
        }
    }
}