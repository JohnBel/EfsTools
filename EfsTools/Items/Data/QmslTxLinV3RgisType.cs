using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxLinV3RgisType
    {
        [FieldCount(64)]
        public ushort[] Rgi
        {
            get;
        }
    }
}