using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/Data_Profiles/Profile6", false, 0x81B6)]
    [Attributes(9)]
    public class Profile6
    {
        [ElementsCount(0)]
        [ElementType("uint8[]")]
        [Description("")]
        public byte[] Values { get; set; }
    }
}