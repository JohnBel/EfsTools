using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1896)]
    [Attributes(9)]
    public sealed class Ipv6Enabled
    {
        public byte Value { get; set; }
    }
}