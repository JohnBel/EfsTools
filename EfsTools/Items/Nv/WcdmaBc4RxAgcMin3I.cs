using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4012)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxAgcMin3
    {
        public short Value { get; set; }
    }
}