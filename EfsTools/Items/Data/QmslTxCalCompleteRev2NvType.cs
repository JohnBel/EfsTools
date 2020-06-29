using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxCalCompleteRev2NvType
    {
        public QmslTxBandCalRev2NvType BandCalData { get; set; }

        [FieldCount(192)]
        public QmslTxCalLinearizerTableNvType[] TxLinData
        {
            get;
        }

        [FieldCount(32)]
        public QmslTxCalLinearizerEptDpdTableNvType[] TxDpdData
        {
            get;
        }
    }
}