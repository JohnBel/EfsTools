using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4785)]
    [Attributes(9)]
    public sealed class WcdmaHsImLevel4
    {
        public short Value { get; set; }
    }
}