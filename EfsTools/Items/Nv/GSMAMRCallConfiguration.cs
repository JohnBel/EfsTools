using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1302)]
    [Attributes(9)]
    public sealed class GsmAmrCallConfiguration
    {
        public byte Value { get; set; }
    }
}