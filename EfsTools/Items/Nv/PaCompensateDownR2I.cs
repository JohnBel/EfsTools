using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2022)]
    [Attributes(9)]
    public sealed class PaCompensateDownR2
    {
        public short Value { get; set; }
    }
}