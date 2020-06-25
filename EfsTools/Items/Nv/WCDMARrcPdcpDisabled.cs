using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4173)]
    [Attributes(9)]
    public sealed class WcdmaRrcPdcpDisabled
    {
        public byte Value { get; set; }
    }
}