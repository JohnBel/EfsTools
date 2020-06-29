using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2024)]
    [Attributes(9)]
    public sealed class PaCompensateDownR3
    {
        public short Value { get; set; }
    }
}