using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxCalCompleteNvType
    {
        public QmslTxBandCalNvType BandCalData { get; set; }

        [FieldCount(192)]
        public QmslTxCalLinearizerTableNvType[] TxLinData
        {
            get;
        }
    }
}