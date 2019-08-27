using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Efs;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1877)]
    [Attributes(9)]
    public class RfBandConfiguration
    {
        [ElementsCount(1)]
        [ElementType("uint64")]
        [Description("")]
        public ulong Value { get; set; }
    }
}