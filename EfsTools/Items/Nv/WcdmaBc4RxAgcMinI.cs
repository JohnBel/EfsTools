using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4022)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxAgcMin
    {
        public short Value { get; set; }
    }
}