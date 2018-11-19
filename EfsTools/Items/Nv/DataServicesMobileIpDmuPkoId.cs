using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(854)]
    [Attributes(41)]
    public class DataServicesMobileIpDmuPkoId
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Index { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PkoId { get; set; }
    }
}