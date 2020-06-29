using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxCalFreqOffsetRowNvType
    {
        [FieldCount(16)]
        public sbyte[] FreqComp
        {
            get;
        }


        public short RgiThreshold { get; set; }
    }
}