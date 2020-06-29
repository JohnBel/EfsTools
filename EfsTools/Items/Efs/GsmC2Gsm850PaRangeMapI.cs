using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025430", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm850PaRangeMap
    {
        public byte PaRangeMap { get; set; }
    }
}