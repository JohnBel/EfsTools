using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class RfnvDataTxEtDpdType
    {
        public ushort EtDpdIndex { get; set; }


        public QmslTxEtDpdAmamsType Amams { get; set; }


        public QmslTxEtDpdAmpmsType Ampms { get; set; }


        public QmslTxEtDpdEpdtsType Epdts { get; set; }
    }
}