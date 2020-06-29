using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxLinV3PwrsType
    {
        [FieldCount(64)]
        public short[] Pwr
        {
            get;
        }
    }
}