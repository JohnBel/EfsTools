using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_plani_config", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsPlaniConfig
    {
        [ElementsCount(128)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}