using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023726", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteGnssBlankingRiseFallDelta
    {
        [FieldCount(2)]
        public short[] RiseDelay { get; set; }
    }
}