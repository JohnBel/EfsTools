using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5944)]
    [Attributes(9)]
    public sealed class WcdmaRxfIciIqTrunc
    {
        public byte Value { get; set; }
    }
}