using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024882", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxLimitVsFreq
    {
        [FieldCount(16)]
        public sbyte[] TxLimitVsFreq { get; set; }
    }
}