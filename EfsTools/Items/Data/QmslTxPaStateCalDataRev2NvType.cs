using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxPaStateCalDataRev2NvType
    {
        [FieldCount(2)]
        public TxFreqOffsetTableType[] TxFreqOffsets
        {
            get;
        }

        [FieldCount(4)]
        public TxLinearizerIndexRev2Type[] TxLinearizerIndex
        {
            get;
        }
    }
}