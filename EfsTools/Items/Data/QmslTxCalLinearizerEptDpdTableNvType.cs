using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxCalLinearizerEptDpdTableNvType
    {
        [FieldCount(64)]
        public EptDpdStruct[] Dpd
        {
            get;
        }
    }
}