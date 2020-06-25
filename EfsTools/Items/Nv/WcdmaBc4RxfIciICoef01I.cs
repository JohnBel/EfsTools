using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5980)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxfIciICoef01
    {
        public uint Value { get; set; }
    }
}