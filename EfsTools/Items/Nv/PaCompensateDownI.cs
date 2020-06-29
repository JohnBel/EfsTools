using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1802)]
    [Attributes(9)]
    public sealed class PaCompensateDown
    {
        public short Value { get; set; }
    }
}