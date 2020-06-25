using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4122)]
    [Attributes(9)]
    public sealed class WlanQosMode
    {
        public byte Value { get; set; }
    }
}