using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class TxLinearizerIndexRev2Type
    {
        [FieldCount(16)]
        public QmslTxCalMultiLinearizerIndexNodeRev2NvType[] NodeType
        {
            get;
        }
    }
}