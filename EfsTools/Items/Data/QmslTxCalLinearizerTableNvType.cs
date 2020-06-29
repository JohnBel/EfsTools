using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxCalLinearizerTableNvType
    {
        public ushort TxChain { get; set; }

        [FieldCount(64)]
        public ushort[] Rgi
        {
            get;
        }

        [FieldCount(64)]
        public short[] Power
        {
            get;
        }

        [FieldCount(64)]
        public uint[] Apt
        {
            get;
        }
    }
}