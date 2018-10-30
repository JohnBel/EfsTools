using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3632)]
    [Attributes(9)]
    public class SearchDebugMask
    {
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}