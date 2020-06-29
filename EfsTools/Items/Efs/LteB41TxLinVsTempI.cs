using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021629", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB41TxLinVsTemp
    {
        [FieldCount(64)]
        public sbyte[] Value { get; set; }
    }
}