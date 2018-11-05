using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/data/iwlan_s2b_config.xml", false, 0x81B6)]
    [Attributes(9)]
    public class IwlanS2bConfigXml
    {
        [ElementsCount(1)]
        [ElementType("string[]")]
        [Description("")]
        public string[] Values { get; set; }
    }
}