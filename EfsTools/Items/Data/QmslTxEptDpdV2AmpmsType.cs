using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxEptDpdV2AmpmsType
    {
        [FieldCount(16)]
        public int[] Ampm
        {
            get;
        }
    }
}