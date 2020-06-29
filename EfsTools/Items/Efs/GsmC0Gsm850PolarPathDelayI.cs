using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025068", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm850PolarPathDelay
    {
        public short PolarPathDelay { get; set; }
    }
}