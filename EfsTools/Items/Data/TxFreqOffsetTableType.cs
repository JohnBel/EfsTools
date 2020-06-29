using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class TxFreqOffsetTableType
    {
        [FieldCount(8)]
        public QmslTxCalFreqOffsetRowNvType[] Row
        {
            get;
        }
    }
}