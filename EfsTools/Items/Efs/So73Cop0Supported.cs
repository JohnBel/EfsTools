using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/cdma/1xcp/so73_cop0_supported", true, 0xE1FF)]
    [Attributes(9)]
    public class So73Cop0Supported
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}