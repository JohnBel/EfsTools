using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020347", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB18TimerHysterisis
    {
        public short Value { get; set; }
    }
}