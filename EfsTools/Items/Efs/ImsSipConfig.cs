using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/ims_sip_config", false, 0x81FF)]
    [Attributes(9)]
    public class ImsSipConfig
    {
        [ElementsCount(1024)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}