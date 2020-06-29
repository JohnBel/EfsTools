using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025427", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm900PaRangeMap
    {
        public byte PaRangeMap { get; set; }
    }
}