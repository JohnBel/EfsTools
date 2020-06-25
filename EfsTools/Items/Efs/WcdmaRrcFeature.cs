using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/wcdma/rrc/wcdma_rrc_feature", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaRrcFeature
    {
        public ushort Value { get; set; }
    }
}