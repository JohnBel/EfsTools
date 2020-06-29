using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1801)]
    [Attributes(9)]
    public sealed class PaCompensateUp
    {
        public short Value { get; set; }
    }
}