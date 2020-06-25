using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4011)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxAgcMin2
    {
        public short Value { get; set; }
    }
}