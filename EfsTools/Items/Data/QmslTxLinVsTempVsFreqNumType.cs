using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxLinVsTempVsFreqNumType
    {
        [FieldCount(8)]
        public QmslTxCalFreqNumType[] Temp
        {
            get;
        }
    }
}