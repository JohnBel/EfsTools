using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile(" /nv/item_files/modem/nas/lte_nas_ignore_mt_csfb_during_volte_call", true, 0xE1FF)]
    [Attributes(9)]
    public class LteNasIgnoreMtCsfbDuringVolteCall
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}