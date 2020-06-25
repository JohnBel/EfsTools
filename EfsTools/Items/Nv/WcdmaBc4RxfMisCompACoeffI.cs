using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5904)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxfMisCompACoeff
    {
        public short Value { get; set; }
    }
}