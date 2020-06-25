using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4023)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxAgcMax
    {
        public short Value { get; set; }
    }
}