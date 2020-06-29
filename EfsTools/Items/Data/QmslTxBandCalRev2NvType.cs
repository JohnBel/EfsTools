using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxBandCalRev2NvType
    {
        [FieldCount(8)]
        public sbyte[] Reserved
        {
            get;
        }

        [FieldCount(16)]
        public ushort[] TxCalChan
        {
            get;
        }

        [FieldCount(4)]
        public QmslTxPaStateCalDataRev2NvType[] TxPaStateCalData
        {
            get;
        }
    }
}