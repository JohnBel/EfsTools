using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/datamodem/protocols/ip6_include_rdnss_opt", true, 0xE1FF)]
    [Attributes(9)]
    public class Ip6IncludeRdnssOpt
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
    }
}