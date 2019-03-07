using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/data/ps_sys_data_configurations.txt", false, 0x81B6)]
    [Attributes(9)]
    public class PsSysDataConfigurationsTxt
    {
        [ElementsCount(1)]
        [ElementType("string[]")]
        [LineEnding(LineEnding.Linux, true)]
        [Description("")]
        public string[] Values { get; set; }
    }
}