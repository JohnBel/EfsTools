using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4400)]
    [Attributes(9)]
    public sealed class WcdmaImLevel4
    {
        public short Value { get; set; }
    }
}