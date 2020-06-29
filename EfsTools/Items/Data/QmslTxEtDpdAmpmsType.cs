using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxEtDpdAmpmsType
    {
        [FieldCount(16)]
        public int[] Ampm
        {
            get;
        }
    }
}