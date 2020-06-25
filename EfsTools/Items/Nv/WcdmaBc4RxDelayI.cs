using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4083)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxDelay
    {
        public short Value { get; set; }
    }
}