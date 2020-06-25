using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6012)]
    [Attributes(9)]
    public sealed class WcdmaBc4RxfIciIqTrunc
    {
        public byte Value { get; set; }
    }
}