using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfnvDataTxEptDpdV2Type
    {
        public ushort EptDpdIndex { get; set; }


        public QmslTxEptDpdV2AmamsType Amams { get; set; }


        public QmslTxEptDpdV2AmpmsType Ampms { get; set; }
    }
}