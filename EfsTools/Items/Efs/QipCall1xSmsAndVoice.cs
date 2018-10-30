using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/ims/qipcall_1xsmsandvoice", true, 0xE1FF)]
    [Attributes(9)]
    public class QipCall1xSmsAndVoice
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}