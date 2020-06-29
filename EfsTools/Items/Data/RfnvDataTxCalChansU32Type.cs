using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfnvDataTxCalChansU32Type
    {
        [FieldCount(16)]
        public uint[] TxCalChans
        {
            get;
        }
    }
}