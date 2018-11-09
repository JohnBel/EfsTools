using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [NvItemId(69673)]
    [EfsFile("/nv/item_files/ims/ims_operation_mode", true, 0xE1FF)]
    [Attributes(9)]
    public class ImsOperationMode
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}