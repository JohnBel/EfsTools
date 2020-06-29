using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxLinV3PaCurrentsType
    {
        [FieldCount(64)]
        public ushort[] Current
        {
            get;
        }
    }
}