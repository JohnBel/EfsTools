using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022931", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class HdrBc15HalfDuplex
    {
        [FieldCount(10)]
        public short[] Value { get; set; }
    }
}