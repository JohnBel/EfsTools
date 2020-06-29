using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class GsmTxSarBackoffDataType
    {
        public short SarGmsk { get; set; }


        public short Sar8psk { get; set; }
    }
}