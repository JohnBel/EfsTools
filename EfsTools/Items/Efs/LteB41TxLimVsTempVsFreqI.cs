using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024581", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB41TxLimVsTempVsFreq
    {
        public byte MatrixEnabled { get; set; }

        [FieldCount(128)]
        public sbyte[] LimVsTempVsFreq { get; set; }
    }
}