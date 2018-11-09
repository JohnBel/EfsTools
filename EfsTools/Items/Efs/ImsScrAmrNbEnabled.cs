using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(67283)]
    [EfsFile("/nv/item_files/ims/ims_scr_amr_nb_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public class ImsScrAmrNbEnabled
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}