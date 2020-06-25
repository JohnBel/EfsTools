using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/wcdma/rrc/wcdma_rrc_fast_return_to_lte_after_csfb", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaRrcFastReturnToLteAfterCsfb
    {
        public byte Value { get; set; }
    }
}