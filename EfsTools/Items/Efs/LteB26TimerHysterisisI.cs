using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024634", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26TimerHysterisis
    {
        public short Value { get; set; }
    }
}