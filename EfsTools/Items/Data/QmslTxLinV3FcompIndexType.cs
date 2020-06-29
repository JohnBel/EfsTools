using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxLinV3FcompIndexType
    {
        public byte FcompType { get; set; }


        public ushort NumFcompUsed { get; set; }

        [FieldCount(64)]
        public ushort[] FcompIdx
        {
            get;
        }
    }
}