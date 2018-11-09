using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(67284)]
    [EfsFile("/nv/item_files/ims/ims_scr_amr_wb_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public class ImsScrAmrWbEnabled
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}