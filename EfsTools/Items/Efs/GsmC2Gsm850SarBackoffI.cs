using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025032", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm850SarBackoff
    {
        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [FieldCount(8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }
}