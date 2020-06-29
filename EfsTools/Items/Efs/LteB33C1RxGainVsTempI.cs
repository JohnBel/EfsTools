using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024889", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C1RxGainVsTemp
    {
        [FieldCount(128)]
        public sbyte[] C1RxGainVsTemp { get; set; }
    }
}