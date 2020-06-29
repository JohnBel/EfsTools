using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024857", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33AgcPaOnRiseFallDelay
    {
        [FieldCount(2)]
        public ushort[] AgcPaOnRiseFallDelayType { get; set; }
    }
}