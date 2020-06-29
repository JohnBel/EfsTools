using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025021", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm900Vbatt
    {
        [FieldCount(3)]
        public ushort[] VbattLevels { get; set; }


        public GsmTxVbattCompDataType VbattCompValueLo { get; set; }


        public GsmTxVbattCompDataType VbattCompValueHi { get; set; }
    }
}