using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class GsmTxVbattCompDataType
    {
        public short VbattCompDbx100 { get; set; }

        [FieldCount(4)]
        public short[] VbattCompParangeDbx100
        {
            get;
        }
    }
}