using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2023)]
    [Attributes(9)]
    public sealed class PaCompensateUpR3
    {
        public short Value { get; set; }
    }
}