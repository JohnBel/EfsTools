using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/datamodem/protocols/ip6_include_rdnss_opt", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Ip6IncludeRdnssOpt
    {
        public byte Value { get; set; }
    }
}