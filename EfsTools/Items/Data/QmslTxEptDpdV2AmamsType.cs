using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxEptDpdV2AmamsType
    {
        [FieldCount(16)]
        public uint[] Amam
        {
            get;
        }
    }
}