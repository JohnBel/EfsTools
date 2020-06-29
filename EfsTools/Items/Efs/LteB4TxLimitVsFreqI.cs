using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020121", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB4TxLimitVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}