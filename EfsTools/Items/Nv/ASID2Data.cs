using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6875)]
    [Attributes(25)]
    public class Asid2Data
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte SessionType { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Reserved { get; set; }
    }
}