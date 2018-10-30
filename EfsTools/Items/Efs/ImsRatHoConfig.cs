using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/ims_rat_ho_config", false, 0x8309)]
    [Attributes(9)]
    public class ImsRatHoConfig
    {
        [ElementsCount(127)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}