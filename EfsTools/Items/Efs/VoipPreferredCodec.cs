using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/voip_prfrd_codec", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class VoipPreferredCodec
    {
        public ushort Value { get; set; }
    }
}