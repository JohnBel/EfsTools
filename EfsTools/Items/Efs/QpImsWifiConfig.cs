using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_wifi_config", false, 0x81FF)]
    [Attributes(9)]
    public class QpImsWifiConfig
    {
        [ElementsCount(512)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}