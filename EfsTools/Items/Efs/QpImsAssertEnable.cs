using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(72609)]
    [EfsFile("/nv/item_files/ims/ims_assert_enable", true, 0xE1FF)]
    [Attributes(9)]
    public class QpImsAssertEnable
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}