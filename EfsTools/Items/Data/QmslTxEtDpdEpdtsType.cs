using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxEtDpdEpdtsType
    {
        [FieldCount(16)]
        public uint[] Epdt
        {
            get;
        }
    }
}