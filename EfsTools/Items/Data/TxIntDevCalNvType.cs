using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class TxIntDevCalNvType
    {
        [FieldCount(8)]
        public ulong[] CdmaBcTxIntCal
        {
            get;
        }

        [FieldCount(8)]
        public byte[] GsmBcTxIntCal
        {
            get;
        }

        [FieldCount(8)]
        public ulong[] WcdmaBcTxIntCal
        {
            get;
        }

        [FieldCount(8)]
        public ulong[] LteBcTxIntCal
        {
            get;
        }

        [FieldCount(8)]
        public ulong[] TdscdmaBcTxIntCal
        {
            get;
        }
    }
}