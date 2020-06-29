using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025073", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm900PolarPathDelay
    {
        public short PolarPathDelay { get; set; }
    }
}