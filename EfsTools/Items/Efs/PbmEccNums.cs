using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/pbm/pbm_ecc_nums", true, 0xE1FF)]
    [Attributes(9)]
    public class PbmEccNums
    {
        [ElementsCount(480)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetStringWithZero(Value);
            set => Value = StringUtils.GetBytesWithZero(value, 480);
        }
    }
}