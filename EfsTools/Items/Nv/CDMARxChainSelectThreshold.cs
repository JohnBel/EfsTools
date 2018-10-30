using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3515)]
    [Attributes(9)]
    public class CdmaRxChainSelectThreshold
    {
        [ElementsCount(2)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
    }
}