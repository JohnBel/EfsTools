using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/wcdma/rrc/wcdma_rrc_csfb_skip_sib11_opt", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaRrcCsfbSkipSib11Opt
    {
        public byte Value { get; set; }
    }
}