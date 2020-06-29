using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxEtDpdAmamsType
    {
        [FieldCount(16)]
        public uint[] Amam
        {
            get;
        }
    }
}