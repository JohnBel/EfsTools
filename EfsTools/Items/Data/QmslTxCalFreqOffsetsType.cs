using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxCalFreqOffsetsType
    {
        [FieldCount(16)]
        public sbyte[] FreqOffset
        {
            get;
        }
    }
}