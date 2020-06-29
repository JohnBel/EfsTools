using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021286", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB20TxGainIndexForApt3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}