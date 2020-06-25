using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/wcdma/rrc/wcdma_ppac_support", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaPpacSupport
    {
        public byte Value { get; set; }
    }
}