using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6876)]
    [Attributes(25)]
    public class DualStandbyConfigItems
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DedicatedVoiceSubs { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DedicatedDataSubs { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ActiveSubs { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PrioritySubs { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte DualStandbyPref { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Reserved { get; set; }
    }
}