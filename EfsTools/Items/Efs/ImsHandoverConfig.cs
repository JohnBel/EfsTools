using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/ims/imshandoverconfig", false, 0x81FF)]
    [Attributes(9)]
    public class ImsHandoverConfig
    {
        [ElementsCount(1)]
        [ElementType("string[]")]
        [Description("")]
        public string[] Values { get; set; }
    }
}