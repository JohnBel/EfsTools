using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024575", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB35TxLimVsTempVsFreq
    {
        public byte MatrixEnabled { get; set; }

        [FieldCount(128)]
        public sbyte[] LimVsTempVsFreq { get; set; }
    }
}