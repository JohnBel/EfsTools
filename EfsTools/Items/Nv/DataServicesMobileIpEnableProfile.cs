using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(714)]
    [Attributes(13)]
    public class DataServicesMobileIpEnableProfile
    {
        public DataServicesMobileIpEnableProfile()
        {
            EnableProfs = new byte[6];
        }
        
        [ElementsCount(6)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] EnableProfs { get; set; }
    }
}