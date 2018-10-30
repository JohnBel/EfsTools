using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/cdma/1xcp/1xcsfb_n_max_reg_retry_cnt", true, 0xE1FF)]
    [Attributes(9)]
    public class OneXCsfbNMaxRegRetryCnt
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}