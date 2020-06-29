using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxCalFreqNumType
    {
        [FieldCount(16)]
        public short[] Freq
        {
            get;
        }
    }
}