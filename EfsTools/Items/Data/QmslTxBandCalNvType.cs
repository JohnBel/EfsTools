using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxBandCalNvType
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
        public QmslTxPaStateCalDataNvType[] TxPaStateCalData
        {
            get;
        }
    }
}