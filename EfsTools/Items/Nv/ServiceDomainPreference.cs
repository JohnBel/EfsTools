using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(850)]
    [Attributes(41)]
    public class ServiceDomainPreference
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Nam { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("2=CS+PS,3=Any")]
        public ushort ServiceDomain { get; set; }
    }
}