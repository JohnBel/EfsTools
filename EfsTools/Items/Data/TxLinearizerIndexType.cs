using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class TxLinearizerIndexType
    {
        [FieldCount(16)]
        public QmslTxCalMultiLinearizerIndexNodeNvType[] NodeType
        {
            get;
        }
    }
}