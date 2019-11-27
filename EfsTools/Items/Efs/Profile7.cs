using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/Data_Profiles/Profile7", false, 0x81B6)]
    [Attributes(9)]
    public class Profile7
    {
        [ElementsCount(0)]
        [ElementType("uint8[]")]
        [Description("")]
        public byte[] Values { get; set; }
    }
}