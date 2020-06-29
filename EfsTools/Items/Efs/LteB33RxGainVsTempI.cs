using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024849", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33RxGainVsTemp
    {
        [FieldCount(128)]
        public sbyte[] RxGainVsTemp { get; set; }
    }
}