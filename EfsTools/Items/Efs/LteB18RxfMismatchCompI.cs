using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020337", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB18RxfMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}