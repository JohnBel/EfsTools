using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(256)]
    [Attributes(41)]
    public class RoamingListEnabled
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Name { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Enabled { get; set; }
    }
}