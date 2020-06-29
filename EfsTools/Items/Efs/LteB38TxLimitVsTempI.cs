using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020405", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB38TxLimitVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}