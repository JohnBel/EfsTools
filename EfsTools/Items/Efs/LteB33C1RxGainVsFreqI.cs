using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024892", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C1RxGainVsFreq
    {
        [FieldCount(128)]
        public sbyte[] C1RxGainVsFreq { get; set; }
    }
}