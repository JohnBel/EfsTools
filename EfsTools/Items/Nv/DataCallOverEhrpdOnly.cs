using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7147)]
    [Attributes(9)]
    public class DataCallOverEhrpdOnly
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte EhrpdOnlyFlag { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte MaxFailureCount { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte MaxFailureTotalCount { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte NewAttemptMaxTimer { get; set; }
    }
}