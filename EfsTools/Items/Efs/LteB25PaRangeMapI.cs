using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022311", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB25PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}