using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5905)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxfMisCompBCoeff
    {
        public short Value { get; set; }
    }
}