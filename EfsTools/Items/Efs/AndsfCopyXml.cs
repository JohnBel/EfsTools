using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/data/andsf_copy.xml", false, 0x81B6)]
    [Attributes(9)]
    public class AndsfCopyXml
    {
        [ElementsCount(1)]
        [ElementType("string[]")]
        [Description("")]
        public string[] Values { get; set; }
    }
}