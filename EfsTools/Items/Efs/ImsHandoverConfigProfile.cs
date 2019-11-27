using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/efsprofiles/imshandoverconfig", false, 0x81FF)]
    [Attributes(9)]
    public class ImsHandoverConfigProfile
    {
        [ElementsCount(1)]
        [ElementType("string[]")]
        [LineEnding(LineEnding.Linux, true)]
        [Description("")]
        public string[] Values { get; set; }
    }
}