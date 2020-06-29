using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024865", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33PaRiseFallThreshold
    {
        [FieldCount(16)]
        public ushort[] PaRiseFallThresholdType { get; set; }
    }
}