using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5824)]
    [Attributes(9)]
    public sealed class WwanAccessOverWifiPreferred
    {
        public byte Value { get; set; }
    }
}