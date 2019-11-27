using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/sms_mandatory", true, 0xE1FF)]
    [Attributes(9)]
    public class SmsMandatory
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}