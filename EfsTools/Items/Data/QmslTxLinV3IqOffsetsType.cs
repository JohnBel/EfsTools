using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxLinV3IqOffsetsType
    {
        [FieldCount(64)]
        public ushort[] IqOffset
        {
            get;
        }
    }
}