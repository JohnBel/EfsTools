using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024974", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1800TxCalData
    {
        public byte TxCalChanSize { get; set; }

        [FieldCount(3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }
}