using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/ims/ims_sip_config", false, 0x81FF)]
    [Attributes(9)]
    public sealed class ImsSipConfig
    {
        [FieldCount(1024)]
        public byte[] Value { get; set; }
    }
}