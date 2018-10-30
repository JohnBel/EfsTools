using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5107)]
    [Attributes(9)]
    public class RepeatedAcch
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }
    }
}